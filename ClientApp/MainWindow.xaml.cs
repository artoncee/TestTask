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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClientApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new LoginPage());
        }

        private void Button_Click_Login(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new LoginPage();
        }

        private void Button_Click_Registration(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new RegistrationPage();
        }

        private void Button_Click_Login_Second(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new SecondLoginPage();
        }
    }
}
