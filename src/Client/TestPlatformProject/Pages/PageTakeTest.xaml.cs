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
        Test test;

        private readonly Service1Client _service1Client;
        public PageTakeTest(Service1Client service1Client)
        {
            InitializeComponent();
            test = new Test();
            _service1Client = service1Client;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            test.Questions.ToList().Add(new Question());
            test.Questions.ToList()[0].Answers.ToList().Add(new Answer());
            test.Questions.ToList()[0].Answers.ToList().Add(new Answer());
            test.Questions.ToList()[0].Answers.ToList().Add(new Answer());
            for (int i = 0; i < test.Questions.ToList()[0].Answers.Count(); i++)
            {
                test.Questions.ToList()[0].Answers.ToList()[0].Text = "1";
            }
            test.Questions.ToList()[0].Text = "Some";
            foreach (Question question in test.Questions)
            {
                List<Question> ListQuestion = new List<Question>();
                List<Answer> ListAnswer = new List<Answer>();
                ListQuestion.Add(new Question() { Text = question.Text });
                foreach(Answer answer in question.Answers)
                {
                    ListAnswer.Add(answer);
                }


                StackPanel stackPanel = new StackPanel();
                stackPanel.Margin = new Thickness(10);
                stackPanel.Children.Add(new Image());
                stackPanel.Children.Add(new TextBlock());

                ((TextBlock)stackPanel.Children[1]).Text = ListQuestion[0].Text;
                for (int i = 0; i < ListAnswer.Count; i++)
                {
                    stackPanel.Children.Add(new CheckBox() { Content = ListAnswer[i].Text });
                }
                if (ListQuestion[0].ImageURL != null)
                {
                    ((Image)stackPanel.Children[0]).Source = (ImageSource)new ImageSourceConverter().ConvertFrom(ListQuestion[0].ImageURL);
                }
                else
                    stackPanel.Children[0].Visibility = Visibility.Hidden;
                StackPanel_Test.Children.Add(stackPanel);
            }





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
