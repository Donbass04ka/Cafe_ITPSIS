using Microsoft.EntityFrameworkCore;
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
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {

        public List<User> Users { get; set; }

        public AdminWindow()
        {
            InitializeComponent();
            LoadData();
            DataContext = this;
        }

        private void LoadData()
        {
            Users = new List<User>();

            foreach(var user in Helper.db.Users.Where(q => q.RoleId != 3).Include(d => d.Role).Include(f => f.Post))
            {
                Users.Add(user);
            }

            UsersDGrid.ItemsSource = Helper.db.Users.Where(q => q.RoleId != 3).Include(d => d.Role).Include(f => f.Post).ToList();
        }

        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void AddUserBtn_Click(object sender, RoutedEventArgs e)
        {
            new AddUserWindow().Show();
            this.Close();
        }

        private void EditUserBtn_Click(object sender, RoutedEventArgs e)
        {
            User selectedUser = UsersDGrid.SelectedItem as User;

            if (selectedUser != null)
            {
                new EditUserWindow(selectedUser).Show();
                this.Close();
            }
        }

        private void DeleteUserBtn_Click(object sender, RoutedEventArgs e)
        {
            User selectedUser = UsersDGrid.SelectedItem as User;

            if (selectedUser != null)
            {
                Helper.db.Users.Remove(selectedUser);
                Helper.db.SaveChanges();
                LoadData();

                MessageBox.Show("Работник удалён из базы");
            }
        }

        private void UsersDGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            User selectedUser = UsersDGrid.SelectedItem as User;

            if (selectedUser != null)
            {
                if (selectedUser.PostId == 1)
                {
                    selectedUser.PostId = 2;
                    Helper.db.SaveChanges();
                    LoadData();
                }
                else
                {
                    selectedUser.PostId = 1;
                    Helper.db.SaveChanges();
                    LoadData();
                }

                MessageBox.Show(
                    "Статус пользователя изменён",
                    "Info",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            UsersDGrid.SelectedItem = null;
        }

        private void CreateOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            new WaiterWindow().Show();
            this.Close();
        }
    }
}
