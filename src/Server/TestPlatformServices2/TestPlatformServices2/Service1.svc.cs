using DataAccess.ModelsUI;
using DataAccess.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace TestPlatformServices2
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Service1 : IService1
    {
        private readonly UnitOfWork unitOfWork;
        public Service1()
        {
            unitOfWork = UnitOfWork.GetInstance();
        }

        public async Task<bool> AddQuestion(Question question)
        {
            await unitOfWork.Questions.CreateAsync(new Question()
            {
                IsManyAnswers = question.IsManyAnswers,
                ImageURL = question.ImageURL,
                Text = question.Text,
                Weight = question.Weight,
                TestId = (await unitOfWork.Tests.FindByConditionAsync(x => x.Id == question.Test.Id)).First().Id
            });
            await unitOfWork.SaveAsync();

            foreach (var item in question.Answers)
            {
                await unitOfWork.Answers.CreateAsync(new Answer() { Text = item.Text, IsCorrect = item.IsCorrect, QuestionId = (await unitOfWork.Questions.GetAllAsync()).Last().Id });
            }

            await unitOfWork.SaveAsync();
            return true;
        }

        public async Task<bool> AddTest(Test test)
        {
            await unitOfWork.Tests.CreateAsync(new Test() { Name = test.Name, Description = test.Description, TryNumber = test.TryNumber });
            await unitOfWork.SaveAsync();
            return true;
        }

        public async Task<bool> RemoveQuestion(int qestionId)
        {
            // (await unitOfWork.Questions.FindByConditionAsync(x=>x.Id == qestionId))
            //TODO Add remove request to DB;
            return false;
        }

        public async Task<bool> RemoveTest(int testId)
        {
            //TODO Add remove request to DB;
            return false;
        }


        public async Task<List<Test>> GetTests()
        {
            return (await unitOfWork.Tests.GetAllAsync()).ToList();
        }

        public async Task<bool> IsAdmin(string login)
        {
            if ((await unitOfWork.Logins.FindByConditionAsync(x => x.Login == login)).Any())
                return (await unitOfWork.Logins.FindByConditionAsync(x => x.Login == login)).First().User.IsAdmin;
            return false;
        }

        public async Task<bool> IsLogin(string password, string login)
        {
            if ((await unitOfWork.Logins.FindByConditionAsync(x => x.Login == login && x.Password == password)).Any()) return true;
            return false;
        }

        public async Task<bool> Registration(string password, string login, string fio, string email)
        {
            if ((await unitOfWork.Logins.FindByConditionAsync(x => x.Login == login)).Any()) return false;

            await unitOfWork.Logins.CreateAsync(new DataAccess.ModelsUI.LoginUser() { Password = password, Login = login });
            await unitOfWork.SaveAsync();
            await unitOfWork.Users.CreateAsync(new DataAccess.ModelsUI.User()
            {
                LoginId = (await unitOfWork.Logins.FindByConditionAsync(x => x.Login == login)).First().Id,
                Email = email,
                FIO = fio,
                IsAdmin = false
            });
            await unitOfWork.SaveAsync();
            return true;
        }
    }
}
