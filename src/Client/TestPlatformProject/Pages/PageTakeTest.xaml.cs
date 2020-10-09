using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestPlatformProject.Pages
{
    /// <summary>
    /// Interaction logic for PageTakeTest.xaml
    /// </summary>
    public partial class PageTakeTest : Page
    {
        Test test = new Test();

        private readonly Service1Client _service1Client;
        public PageTakeTest(Service1Client service1Client)
        {
            InitializeComponent();

            _service1Client = service1Client;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //////// тестировал  test переопределил в а и б но в foreach используется test
            var a = test.Questions.ToList();
            a.Add(new Question());
            var b = a[0].Answers.ToList();
            for(int i = 0; i < 4; i++)
            {

                a.Add(new Question() { Text = "Some question", ImageURL = "",});
                b.Add(new Answer() { Text = "1" });
                b.Add(new Answer() { Text = "1" });
                b.Add(new Answer() { Text = "1" });

                //test.Questions.ToList().Add(new Question() { Text = "Some question", ImageURL = "", });
                //(test.Questions.ToList()[0]).Answers.ToList().Add(new Answer() { Text = "1" });
                //(test.Questions.ToList()[0]).Answers.ToList().Add(new Answer() { Text = "1" });
                //(test.Questions.ToList()[0]).Answers.ToList().Add(new Answer() { Text = "1" });
            }

                StackPanel stackPanel = new StackPanel();
                stackPanel.Children.Add(new Image());
                stackPanel.Children.Add(new TextBlock());
                ((Image)stackPanel.Children[0]).Source = (ImageSource)new ImageSourceConverter().ConvertFrom(a[0].ImageURL);
            ((TextBlock)stackPanel.Children[1]).Text = a[0].Text;
                for (int i = 0; i < b.Count; i++)
                {
                    stackPanel.Children.Add(new CheckBox() { Content = b[i].Text });
                }
                if (a[0].ImageURL == "") stackPanel.Children[0].Visibility = Visibility.Hidden;
                StackPanel_Test.Children.Add(stackPanel);



            ////////////





            // код надо протестить должен работать
            //foreach (Question question in test.Questions)
            //{
            //    StackPanel stackPanel = new StackPanel();
            //    stackPanel.Children.Add(new Image());
            //    stackPanel.Children.Add(new TextBlock());
            //    ((Image)stackPanel.Children[0]).Source = (ImageSource)new ImageSourceConverter().ConvertFrom(question.ImageURL);
            //    ((TextBlock)stackPanel.Children[1]).Text = question.Text;
            //    for (int i = 0; i < question.Answers.Count(); i++)
            //    {
            //        stackPanel.Children.Add(new CheckBox() { Content = question.Answers.ToList()[i].Text });
            //    }
            //   if (question.ImageURL == "") stackPanel.Children[0].Visibility = Visibility.Hidden;
            //    StackPanel_Test.Children.Add(stackPanel);
            //}
        }
    }
}
