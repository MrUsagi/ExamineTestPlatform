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
    /// Interaction logic for AdminPage.xaml
    /// </summary>
    public partial class AddAdminPage : Page
    {
        private readonly Service1Client _service1Client;
        public AddAdminPage(Service1Client service1Client)
        {
            InitializeComponent();

            _service1Client = service1Client;
        }

        private void AddtTestButton_Click(object sender, RoutedEventArgs e)
        {
            int tryCount;
            if (int.TryParse(AddDescriptionTextBox.Text, out tryCount))
            {
                _service1Client.AddTestAsync(new Test() { Name = AddNameTestTextBox.Text, Description = AddDescriptionTextBox.Text, TryNumber = tryCount, IsRemove = false });
            }
        }
    }
}
