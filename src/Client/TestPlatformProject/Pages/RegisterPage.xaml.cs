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
using TestPlatformProject.Models;

namespace TestPlatformProject.Pages
{
    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        private readonly Service1Client _service1Client;
        public RegisterPage(Service1Client service1Client)
        {
            InitializeComponent();

            _service1Client = service1Client;
        }

        private async void loginButtonInRegister_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTextBoxInRegister.Text != "")
            {
                if ((await _service1Client.RegistrationAsync(PassTextBoxInRegister.Text, LoginTextBoxInRegister.Text, NameTextBoxInRegister.Text, EmailTextBoxInRegister.Text)))
                {
                    CurrentUser.User = await _service1Client.GetUserAsync(LoginTextBoxInRegister.Text);
                    this.NavigationService.Navigate(new UserPage(_service1Client));
                }
            }
        }
    }
}
