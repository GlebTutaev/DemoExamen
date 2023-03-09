using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DemoExamen.Windows
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void GuestLogIn_Click(object sender, RoutedEventArgs e)
        {
            Guest guest = new Guest();
            guest.Show();
            Close();
        }

        private void Login_MouseEnter(object sender, MouseEventArgs e)
        {
            Login.Background = Brushes.Red;
        }
    }
}
