using DataAccess.UOW;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
        UnitOfWork unitOfWork = new UnitOfWork();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public async Task<bool> IsLogin(string password, string login)
        {
            if( (await unitOfWork.Logins.FindByConditionAsync(x=>x.Login == login)).Any()) return false;
            
            await unitOfWork.Logins.CreateAsync(new DataAccess.Models.LoginUser() { Password = password, Login = login});

            return true;
        }

        public bool Registration(string password, string login, string fio, string email)
        {
            throw new NotImplementedException();
        }
    }
}
