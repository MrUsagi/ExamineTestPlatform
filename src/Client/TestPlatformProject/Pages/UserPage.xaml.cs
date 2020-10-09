using ServiceReference1;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestPlatformProject.Pages
{
    /// <summary>
    /// Interaction logic for UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        private readonly Service1Client _service1Client;
        public UserPage(Service1Client service1Client)
        {
            InitializeComponent();

            _service1Client = service1Client;
        }

        private void Button_TakeTest(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Exit(object sender, RoutedEventArgs e)
        {
        }
    }
}
