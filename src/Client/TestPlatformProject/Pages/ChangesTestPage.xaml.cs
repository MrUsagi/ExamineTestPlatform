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
    /// Логика взаимодействия для ChangesTestPage.xaml
    /// </summary>
    public partial class ChangesTestPage : Page
    {
        private readonly Service1Client _service1Client;
        public ChangesTestPage(Service1Client service1Client)
        {
            InitializeComponent();

            _service1Client = service1Client;
            AddAnswerButton.Click += clickLastButton;
            AddQuestionButton.Click += clickFirstButton;
        }

        private void clickFirstButton(object sender, RoutedEventArgs e)
        {
            ChangesAnswerScrollPanel.Children.Add(new TextBlock() { FontSize = 15, FontStyle = FontStyles.Italic, Foreground = new SolidColorBrush(Color.FromRgb(255, 69, 0)), Margin = new Thickness(40, 30, 40, 0), Text = "Введите вопрос:" });
            ChangesAnswerScrollPanel.Children.Add(new TextBox() {  Margin = new Thickness(40, 10, 40, 0) });
            ChangesAnswerScrollPanel.Children.Add(new TextBlock() { FontSize = 15, FontStyle = FontStyles.Italic, Foreground = new SolidColorBrush(Color.FromRgb(255, 69, 0)), Margin = new Thickness(40, 30, 40, 0), Text = "Введите URL фото если оно надо:" });
            ChangesAnswerScrollPanel.Children.Add(new TextBox() {  Margin = new Thickness(40, 10, 40, 0) });
            ChangesAnswerScrollPanel.Children.Add(new TextBlock() { FontSize = 15, FontStyle = FontStyles.Italic, Foreground = new SolidColorBrush(Color.FromRgb(255, 69, 0)), Margin = new Thickness(40, 30, 40, 0), Text = "Вариант ответа:" });
            ChangesAnswerScrollPanel.Children.Add(new StackPanel() { Orientation = Orientation.Horizontal });
            ((StackPanel)ChangesAnswerScrollPanel.Children[ChangesAnswerScrollPanel.Children.Count - 1]).Children.Add(new TextBox() { Width = 200, Height = 17, Margin = new Thickness(40, 10, 20, 0) });
            ((StackPanel)ChangesAnswerScrollPanel.Children[ChangesAnswerScrollPanel.Children.Count - 1]).Children.Add(new CheckBox() { Margin = new Thickness(15, 12, 0, 0) });
     

        }

        private void clickLastButton(object sender, RoutedEventArgs e)
        {

            ChangesAnswerScrollPanel.Children.Add(new TextBlock() { FontSize = 15, FontStyle = FontStyles.Italic, Foreground = new SolidColorBrush(Color.FromRgb(255, 69, 0)), Margin = new Thickness(40, 30, 40, 0), Text = "Вариант ответа:" });

            ChangesAnswerScrollPanel.Children.Add(new StackPanel() { Orientation = Orientation.Horizontal });
            ((StackPanel)ChangesAnswerScrollPanel.Children[ChangesAnswerScrollPanel.Children.Count - 1]).Children.Add(new TextBox() { Width = 200, Height = 17, Margin = new Thickness(40, 10, 20, 0) });
            ((StackPanel)ChangesAnswerScrollPanel.Children[ChangesAnswerScrollPanel.Children.Count - 1]).Children.Add(new CheckBox() { Margin = new Thickness(15, 12, 0, 0) });

        }
    }
}
