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

namespace TestPlatformProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Service1Client service1Client = new Service1Client();
        public MainWindow()
        {
            InitializeComponent();

            //MessageBox.Show(service1Client.GetDataAsync(3).Result);
            var s = service1Client.IsLoginAsync("asd", "asdasd").Result;
        }



    }
}
