﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CafeWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LogInBtn_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTBox.Text == "" || PasswordPBox.Password == "")
            {
                MessageBox.Show("Введите логин и пароль");
            } else
            {
                User user = Helper.db.Users.FirstOrDefault(q => q.Login == LoginTBox.Text && q.Password == PasswordPBox.Password);
                if (user != null)
                {
                    if (user.RoleId == 1 && user.PostId != 2) // Официант
                    {
                        new WaiterWindow().Show();
                        this.Close();
                    } if(user.RoleId == 2 && user.PostId != 2) //Повар
                    {
                        new CookWindow().Show();
                        this.Close();
                    }
                    if (user.RoleId == 3 && user.PostId != 2) //Админ
                    {
                        new AdminWindow().Show();
                        this.Close();
                    }
                    if (user.PostId == 2) //Уволен
                    {
                        new ErrorPostWindow().Show();
                    }

                    Helper.userSession = user;
                } else
                {
                    MessageBox.Show("Неправильные логин или пароль");
                }
            }
        }
    }
}
