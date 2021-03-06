﻿using ServiceReference1;
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
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        private readonly Service1Client _service1Client;
        public AdminPage(Service1Client service1Client)
        {
            InitializeComponent();

            _service1Client = service1Client;
        }

        private void AddTestButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddAdminPage(_service1Client));
        }

        private async void DeleteTestButton_Click(object sender, RoutedEventArgs e)
        {
            if(TestsLIstView.SelectedItem != null)
            {
                TestsLIstView.Items.RemoveAt(TestsLIstView.SelectedIndex);

                // _service1Client.RemoveTestAsync();
                //TODO add request to service 
            }
        }

        private void DeleteAskButton_Click(object sender, RoutedEventArgs e)
        {
            if (QuastionLIstView.SelectedItem != null)
            {
                QuastionLIstView.Items.RemoveAt(QuastionLIstView.SelectedIndex);
                //TODO add request to service 
            }
        }

        private void AddAskButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ChangesTestPage(_service1Client));
        }

        private async void TestsLIstView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(TestsLIstView.SelectedItem != null)
            {
                CurrentUser.SelectedTest = await _service1Client.GetTestAsync((TestsLIstView.SelectedItem as Test).Id);
                this.DataContext = CurrentUser.SelectedTest;
                //QuastionLIstView.Items.Clear();
                QuastionLIstView.ItemsSource = null;
                var questions = await _service1Client.LoadQuestionsAsync((TestsLIstView.SelectedItem as Test).Id);
                QuastionLIstView.ItemsSource = questions;
                //QuastionLIstView.ItemsSource = (TestsLIstView.SelectedItem as Test).Questions;
            }
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var tests = await _service1Client.LoadTestsAsync();
            TestsLIstView.ItemsSource = tests;
        }
    }
}
