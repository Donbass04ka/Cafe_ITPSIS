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
    /// Логика взаимодействия для ErrorPostWindow.xaml
    /// </summary>
    public partial class ErrorPostWindow : Window
    {
        public ErrorPostWindow()
        {
            InitializeComponent();
        }

        private void LogInBtn_Click(object sender, RoutedEventArgs e) //Уволен
        {
            this.Close();
        }

    }
}
