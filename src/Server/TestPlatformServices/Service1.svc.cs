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

namespace TestPlatformServices
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Service1 : IService1
    {
        private IServiceProvider ServiceProvider;
        private IConfiguration Configuration;
        public bool Connect()
        {





            return true;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public bool IsLogin(string password, string login)
        {
            return true;
        }

        public bool Registration(string password, string login, string fio, string email)
        {
            throw new NotImplementedException();
        }


        private void ConfigurationService(IServiceCollection services)
        {
            ConfigurationManagerBll.Configuration(services, Configuration.GetConnectionString("SqlConnection"));

           // services.AddSingleton(typeof(TCPServer));

        }

        private void OnStartup()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true);
            Configuration = builder.Build();
            var serviceCollection = new ServiceCollection();
            
            ConfigurationService(serviceCollection);
            ServiceProvider = serviceCollection.BuildServiceProvider();

            server = ServiceProvider.GetRequiredService<TCPServer>();
        }
    }
}
