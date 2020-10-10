using DataAccess.Models;
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
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Task<bool> IsLogin(string password, string login);

        [OperationContract]
        Task<bool> IsAdmin(string login);

        [OperationContract]
        Task<bool> Registration(string password, string login, string fio, string email);

        [OperationContract]
        Task<bool> AddTest(Test test);

        [OperationContract]
        Task<bool> AddQuestion(Question question);

        [OperationContract]
        Task<bool> RemoveTest(int testId);

        [OperationContract]
        Task<bool> RemoveQuestion(int qestionId);


        [OperationContract]
        Task<bool> AddResoultTest(int idTest, int idUser, int result);

        [OperationContract]
        Task<List<Test>> GetTests();

        [OperationContract]
        Task<User> GetUser(string login);

        [OperationContract]
        Task<IEnumerable<Test>> LoadTests();

        [OperationContract]
        Task<IEnumerable<Question>> LoadQuestions(int testId);
        
        [OperationContract]
        Task<Test> GetTest(int testId);

        // TODO: Добавьте здесь операции служб
    }


    // Используйте контракт данных, как показано в примере ниже, чтобы добавить составные типы к операциям служб.
    //[DataContract]
    //public class CompositeType
    //{
    //    bool boolValue = true;
    //    string stringValue = "Hello ";

    //    [DataMember]
    //    public bool BoolValue
    //    {
    //        get { return boolValue; }
    //        set { boolValue = value; }
    //    }

    //    [DataMember]
    //    public string StringValue
    //    {
    //        get { return stringValue; }
    //        set { stringValue = value; }
    //    }
    //}
}
