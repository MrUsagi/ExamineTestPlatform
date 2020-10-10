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
using DataAccess.ModelsUI;
using TestPlatformProject.Models;

namespace TestPlatformProject.Pages
{
    /// <summary>
    /// Interaction logic for PageTakeTest.xaml
    /// </summary>
    public partial class PageTakeTest : Page
    {
        Test test;

        private readonly Service1Client _service1Client;
        public PageTakeTest(Service1Client service1Client,Test test)
        {
            InitializeComponent();
            this.test = test;
            _service1Client = service1Client;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            TextBlock_NameTest.Text = test.Name;
            //var listtmp = test.Questions.ToList();
            //listtmp.Add(new QuestionUI());
            //var listtmpanswer = listtmp[0].Answers.ToList();
            //listtmp[0].Text = "Some";
            //listtmpanswer.Add(new AnswerUI() { Text = "1" });
            //listtmpanswer.Add(new AnswerUI() { Text = "2" });
            //listtmpanswer.Add(new AnswerUI() { Text = "3" });
            //foreach (Question question in test.Questions)
            //{
            //    List<Question> ListQuestion = new List<Question>();
            //    List<Answer> ListAnswer = new List<Answer>();
            //    ListQuestion.Add(new Question() { Text = question.Text });
            //    for (int i = 0; i < question.Answers.Count(); i++)
            //    {
            //        ListAnswer.Add(question.Answers.ToList()[i]);
            //    }


            //    StackPanel stackPanel = new StackPanel();
            //    stackPanel.Margin = new Thickness(10);
            //    stackPanel.Children.Add(new Image());
            //    stackPanel.Children.Add(new TextBlock());

            //    ((TextBlock)stackPanel.Children[1]).Text = ListQuestion[0].Text;
            //    for (int i = 0; i < ListAnswer.Count; i++)
            //    {
            //        stackPanel.Children.Add(new CheckBox() { Content = ListAnswer[i].Text });
            //    }
            //    if (ListQuestion[0].ImageURL != null)
            //    {
            //        ((Image)stackPanel.Children[0]).Source = (ImageSource)new ImageSourceConverter().ConvertFrom(ListQuestion[0].ImageURL);
            //    }
            //    else
            //        stackPanel.Children[0].Visibility = Visibility.Hidden;
            //    StackPanel_Test.Children.Add(stackPanel);
            //}





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

        private async void Button_Send(object sender, RoutedEventArgs e)
        {
            //int balls = 0;
            //for (int i = 0; i < StackPanel_Test.Children.Count; i++)
            //{
            //    foreach (Answer answerUI in test.Questions.ToList()[i].Answers.ToList())
            //    {
            //        for (int j = 2; j < 5; j++)
            //        {
            //            if (((CheckBox)((StackPanel)StackPanel_Test.Children[i]).Children[j]).IsChecked == true)
            //            {
            //                if (((CheckBox)((StackPanel)StackPanel_Test.Children[i]).Children[j]).Content == answerUI.Text) balls++;
            //            }
            //        }
            //    }
            //}
            //await _service1Client.AddResoultTestAsync(test.Id, CurrentUser.User.Id, balls);
        }
    }
}
