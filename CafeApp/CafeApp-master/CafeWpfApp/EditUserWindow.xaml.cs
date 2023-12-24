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
    /// Логика взаимодействия для EditUserWindow.xaml
    /// </summary>
    public partial class EditUserWindow : Window
    {
        public List<Role> roleNames { get; set; } //Вот он список ролей
        private List<User> userEdit = new List<User>();
        public  User SelectedUser { get; set; }
        public Role SelectedRole { get; set; }
        public EditUserWindow(User selectedUser)
        {
            InitializeComponent();
            SelectedUser = selectedUser;
            DataContext = this;
            LoadData();
        }

        private void LoadData()
        {
            roleNames = new List<Role>(); //Поменял тип на роль
            SelectedRole = SelectedUser.Role; //Выбранная роль - та, которая стоит у выбранного пользователя
            foreach (var role in Helper.db.Roles) //Загрузил роли в список
            {
                roleNames.Add(role);
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new AdminWindow().Show();
            this.Close();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTBox.Text == "" ||  FirstTBox.Text == "" || SecondTBox.Text == "" || LastTBox.Text == "" || comboBoxRole == null)
            {
                MessageBox.Show("Не все данные заполнены!");
            }
            else
            {

                var dbUser = Helper.db.Users.FirstOrDefault(u => u.Id == SelectedUser.Id);

                if (dbUser != null)
                {
                    Helper.db.Users.Update(SelectedUser);
                    Helper.db.SaveChanges();
                    MessageBox.Show("Пользователь изменён!");
                    new AdminWindow().Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Не найден пользователь!");
                }
            }
        }
    }
}
