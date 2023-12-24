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
    /// Логика взаимодействия для AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        public List<String> roleNames { get; set; }
        public AddUserWindow()
        {
            InitializeComponent();
            DataContext = this;
            LoadData();
        }

        private void LoadData()
        {
            roleNames = new List<String>();
            foreach (var role in Helper.db.Roles)
            {
                roleNames.Add(role.Title);
            }
          
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new AdminWindow().Show();
            this.Close();
        }


        private void AddOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTBox.Text == "" || PasswordPBox.Text == "" || FirstTBox.Text == "" || SecondTBox.Text == "" || LastTBox.Text == "" || comboBoxRole == null)
            {
                MessageBox.Show("Не все данные заполнены!");
            }
            else
            {
                User newUser = new User() { FirstName = FirstTBox.Text, SecondName = SecondTBox.Text, LastName = LastTBox.Text, Login = LoginTBox.Text,
                    Password = PasswordPBox.Text, RoleId = comboBoxRole.SelectedIndex + 1, PostId = 1};

                Helper.db.Users.Add(newUser);
                Helper.db.SaveChanges();

                MessageBox.Show("Пользователь зарегистрирован!");
                new AddUserWindow().Show();
                this.Close();

            }
        }


    }
}
