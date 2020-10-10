using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Context.Initializers
{
    public static class TestsInitializer
    {
        public static void Initialize(TestsContext context)
        {
            context.Database.EnsureCreated();
            if (context.Users.Any()) return;
            context.Users.Add(new User()
            {
                FIO = "Administrator",
                Email = "tests@some.com",
                IsAdmin = true,
                Login = new LoginUser()
                {
                    Login = "root",
                    Password = "root", //Нужна хеш версия, БЛЯТЬ
                }
            });
            context.SaveChanges();

            context.Tests.Add(new Test()
            {
                Name = "MyTest",
                Description = "fuck you",
                TryNumber = 5,
                IsRemove = false,
                Questions = new List<Question>() {
                    new Question(){
                        Text = "White and ...",
                        Answers = new List<Answer>()
                        {
                            new Answer() {
                                IsCorrect = true,
                                Text = "Black"
                            },
                            new Answer()
                            {
                                IsCorrect = false,
                                Text = "Green"
                            },
                            new Answer()
                            {
                                IsCorrect = false,
                                Text = "Blue"
                            }
                        }
                    }
                }
            }) ;

            context.SaveChanges();
        }
    }
}
