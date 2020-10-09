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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private readonly Service1Client _service1Client;
        public LoginPage(Service1Client service1Client)
        {
            InitializeComponent();

            _service1Client = service1Client;
        }

        private async void loginButtonInLogin_Click(object sender, RoutedEventArgs e)
        {
            if (await _service1Client.IsLoginAsync(LoginTextBoxInLogin.Text, PassTextBoxInLogin.Text))
            {
                if(await _service1Client.IsAdminAsync(LoginTextBoxInLogin.Text))
                    this.NavigationService.Navigate(new AdminPage(_service1Client));
                else this.NavigationService.Navigate(new UserPage(_service1Client));
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void registerButtonInLogin_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RegisterPage(_service1Client));
        }
    }
}
