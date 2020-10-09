using DataAccess.UOW;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace TestPlatformServices
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
        public async Task<bool> IsLogin(string password, string login)
        {
            if ((await unitOfWork.Logins.FindByConditionAsync(x => x.Login == login)).Any()) return false;

            await unitOfWork.Logins.CreateAsync(new DataAccess.Models.LoginUser() { Password = password, Login = login });

            return true;
        }

        Task<bool> IService1.Registration(string password, string login, string fio, string email)
        {
            throw new NotImplementedException();
        }
    }
}
