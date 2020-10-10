using ServiceReference1;
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
using TestPlatformProject.Pages;

namespace TestPlatformProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Service1Client _service1Client;
        public MainWindow(Service1Client service1Client)
        {
            InitializeComponent();

            _service1Client = service1Client;
            //MessageBox.Show(service1Client.GetDataAsync(3).Result);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new LoginPage(_service1Client));
        }
    }
}
