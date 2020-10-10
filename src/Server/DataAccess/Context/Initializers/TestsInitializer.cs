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

            context.Tests.Add(new Test() { Name = "MyTest", Description = "fuck you", TryNumber = 5, IsRemove = false });

            context.SaveChanges();
        }
    }
}
