using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CafeWpfApp
{
    /// <summary>
    /// Логика взаимодействия для EditOrderWindow.xaml
    /// </summary>
    public partial class EditOrderWindow : Window
    {
        private Order selectedOrder;
        private List<DishesInOrder> dishesInOrders = new List<DishesInOrder>();
        public List<Table> Tables { get; set; }
        public List<PaymentMethod> payName { get; set; }
        public PaymentMethod SelectedPay { get; set; }
        public Table SelectedTable { get; set; }
        public int Count { get; set; }

        public EditOrderWindow(Order selectedOrder)
        {
            InitializeComponent();
            this.selectedOrder = selectedOrder;
            DataContext = this;
            LoadData();
        }

        private void LoadData()
        {
            DishesDGrid.ItemsSource = Helper.db.Dishes.ToList();

            dishesInOrders.Clear();
            foreach (DishInOrder dish in Helper.db.DishInOrders.Where(x => x.OrderId == selectedOrder.Id).ToList())
            {
                dishesInOrders.Add(new DishesInOrder()  
                {
                    Id = dish.Id,
                    Count = dish.DishCount,
                    Title = dish.Dish.Title
                });
            }
            DishesInOrderDGrid.ItemsSource = dishesInOrders.ToList();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new WaiterWindow().Show();
            this.Close();
        }

        private void DishesDGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Dish selectedDish = DishesDGrid.SelectedItem as Dish;

            if (selectedDish != null)
            {
                DishInOrder dish = Helper.db.DishInOrders.FirstOrDefault(q => q.OrderId == selectedOrder.Id && q.DishId == selectedDish.Id);
                if (dish != null)
                {
                    dish.DishCount++;
                    Helper.db.SaveChanges();
                }
                else
                {
                    Helper.db.DishInOrders.Add(new DishInOrder()
                    {
                        OrderId = selectedOrder.Id,
                        DishId = selectedDish.Id,
                        DishCount = 1
                    });
                    Helper.db.SaveChanges();
                }

                LoadData();
            }

            DishesDGrid.SelectedItem = null;
        }

        private void DishesInOrderDGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DishesInOrder selectedDishesInOrder = DishesInOrderDGrid.SelectedItem as DishesInOrder;
            

            if (selectedDishesInOrder != null)
            {
                //DishInOrder dishInOrder = Helper.db.DishInOrders.FirstOrDefault(q => q.OrderId == selectedOrder.Id && q.DishId == selectedDishesInOrder.Id); //здесь не находится блюдо
               
                DishInOrder dishInOrder = new DishInOrder(){OrderId = selectedOrder.Id, DishCount = 1, DishId = 15 };

                if (selectedDishesInOrder.Count > 1)
                {
                    
                    dishInOrder.DishCount--;
                    Helper.db.SaveChanges();
                }
                else
                {
                    //Helper.db.DishInOrders.Remove(dishInOrder);
                    //Helper.db.SaveChanges();
                }

                LoadData();
            }

            DishesInOrderDGrid.SelectedItem = null;
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
                var dbOrder = Helper.db.Orders.FirstOrDefault(u => u.Id == selectedOrder.Id);

                if (dbOrder != null)
                {
                    Helper.db.Orders.Update(selectedOrder);
                    Helper.db.SaveChanges();
                    MessageBox.Show("Заказ изменён!");
                    new WaiterWindow().Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Не найден заказ!");
                }
        }
    }
}
