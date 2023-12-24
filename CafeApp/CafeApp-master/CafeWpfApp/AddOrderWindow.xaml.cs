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
    /// Логика взаимодействия для AddOrderWindow.xaml
    /// </summary>
    public partial class AddOrderWindow : Window
    {
        private List<DishesInOrder> dishesInOrders = new List<DishesInOrder>();
        public List<Table> Tables{ get; set; }
        public List<PaymentMethod> payName { get; set; }
        public PaymentMethod SelectedPay { get; set; }
        public Table SelectedTable { get; set; }
        public int Count { get; set; }

        public AddOrderWindow()
        {
            InitializeComponent();
            DataContext = this;
            LoadData();
        }

        private void LoadData()
        {
            DishesDGrid.ItemsSource = Helper.db.Dishes.ToList();
            DishesInOrderDGrid.ItemsSource = dishesInOrders.ToList();

            Tables = new List<Table>();
            foreach (var table in Helper.db.Tables)
            {
                Tables.Add(table);
            }

            payName = new List<PaymentMethod>();
            foreach (var payment in Helper.db.PaymentMethods)
            {
                payName.Add(payment);
            }
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
                DishesInOrder newDishesInOrder = new DishesInOrder()
                {
                    Id = selectedDish.Id,
                    Title = selectedDish.Title
                };

                
                DishesInOrder dish = dishesInOrders.FirstOrDefault(q => q.Id == newDishesInOrder.Id);
                if (dish != null)
                {
                    dish.Count++;
                } else
                {
                    newDishesInOrder.Count = 1;
                    dishesInOrders.Add(newDishesInOrder);
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
                if (selectedDishesInOrder.Count > 1)
                {
                    selectedDishesInOrder.Count--;
                } else
                {
                    dishesInOrders.Remove(selectedDishesInOrder);
                }

                LoadData();
            }
                       
            DishesInOrderDGrid.SelectedItem = null;
        }


        private void AddOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (dishesInOrders.Count != 0)
            {
                Order order = new Order()
                {
                    UserId = Helper.userSession.Id,
                    DateCreate = DateTime.Now,
                    StatusOrderId = 1,
                    PaymentMethodId = comboBoxPay.SelectedIndex + 1,
                    TableId = SelectedTable.Id,
                    PaymentMethod = SelectedPay,
                    CountGuest = Count
                };
                Helper.db.Orders.Add(order);
                Helper.db.SaveChanges();

                Order lastOrder = Helper.db.Orders.OrderByDescending(o => o.Id).ToList()[0];

                foreach (DishesInOrder dish in dishesInOrders.ToList() )
                {
                    DishInOrder dishInOrder = new DishInOrder()
                    {
                        DishId = dish.Id,

                        OrderId = lastOrder.Id,
                        DishCount = dish.Count
                    };
                    Helper.db.DishInOrders.Add(dishInOrder);
                    Helper.db.SaveChanges();
                }

                MessageBox.Show("Заказ добавлен.");
                new WaiterWindow().Show();
                this.Close();
            }
            else {
                MessageBox.Show("Добавьте блюда и/или напитки в заказ.");
            }
        }

       
    }
}
