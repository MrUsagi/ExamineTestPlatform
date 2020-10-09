﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Test", Namespace="http://schemas.datacontract.org/2004/07/DataAccess.Models")]
    public partial class Test : object
    {
        
        private string DescriptionField;
        
        private int IdField;
        
        private string NameField;
        
        private ServiceReference1.Question[] QuestionsField;
        
        private int TryNumberField;
        
        private ServiceReference1.UserTest[] UsersField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Question[] Questions
        {
            get
            {
                return this.QuestionsField;
            }
            set
            {
                this.QuestionsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TryNumber
        {
            get
            {
                return this.TryNumberField;
            }
            set
            {
                this.TryNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.UserTest[] Users
        {
            get
            {
                return this.UsersField;
            }
            set
            {
                this.UsersField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Question", Namespace="http://schemas.datacontract.org/2004/07/DataAccess.Models")]
    public partial class Question : object
    {
        
        private ServiceReference1.Answer[] AnswersField;
        
        private int IdField;
        
        private string ImageURLField;
        
        private bool IsManyAnswersField;
        
        private ServiceReference1.Test TestField;
        
        private int TestIdField;
        
        private string TextField;
        
        private int WeightField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Answer[] Answers
        {
            get
            {
                return this.AnswersField;
            }
            set
            {
                this.AnswersField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImageURL
        {
            get
            {
                return this.ImageURLField;
            }
            set
            {
                this.ImageURLField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsManyAnswers
        {
            get
            {
                return this.IsManyAnswersField;
            }
            set
            {
                this.IsManyAnswersField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Test Test
        {
            get
            {
                return this.TestField;
            }
            set
            {
                this.TestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TestId
        {
            get
            {
                return this.TestIdField;
            }
            set
            {
                this.TestIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text
        {
            get
            {
                return this.TextField;
            }
            set
            {
                this.TextField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Weight
        {
            get
            {
                return this.WeightField;
            }
            set
            {
                this.WeightField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserTest", Namespace="http://schemas.datacontract.org/2004/07/DataAccess.Models")]
    public partial class UserTest : object
    {
        
        private int IdField;
        
        private int ResultField;
        
        private ServiceReference1.Test TestField;
        
        private int TestIdField;
        
        private ServiceReference1.User UserField;
        
        private int UserIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Result
        {
            get
            {
                return this.ResultField;
            }
            set
            {
                this.ResultField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Test Test
        {
            get
            {
                return this.TestField;
            }
            set
            {
                this.TestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TestId
        {
            get
            {
                return this.TestIdField;
            }
            set
            {
                this.TestIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.User User
        {
            get
            {
                return this.UserField;
            }
            set
            {
                this.UserField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId
        {
            get
            {
                return this.UserIdField;
            }
            set
            {
                this.UserIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Answer", Namespace="http://schemas.datacontract.org/2004/07/DataAccess.Models")]
    public partial class Answer : object
    {
        
        private int IdField;
        
        private bool IsCorrectField;
        
        private ServiceReference1.Question QuestionField;
        
        private int QuestionIdField;
        
        private string TextField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsCorrect
        {
            get
            {
                return this.IsCorrectField;
            }
            set
            {
                this.IsCorrectField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Question Question
        {
            get
            {
                return this.QuestionField;
            }
            set
            {
                this.QuestionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int QuestionId
        {
            get
            {
                return this.QuestionIdField;
            }
            set
            {
                this.QuestionIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text
        {
            get
            {
                return this.TextField;
            }
            set
            {
                this.TextField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/DataAccess.Models")]
    public partial class User : object
    {
        
        private string EmailField;
        
        private string FIOField;
        
        private int IdField;
        
        private bool IsAdminField;
        
        private ServiceReference1.LoginUser LoginField;
        
        private int LoginIdField;
        
        private ServiceReference1.UserTest[] TestsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FIO
        {
            get
            {
                return this.FIOField;
            }
            set
            {
                this.FIOField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsAdmin
        {
            get
            {
                return this.IsAdminField;
            }
            set
            {
                this.IsAdminField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.LoginUser Login
        {
            get
            {
                return this.LoginField;
            }
            set
            {
                this.LoginField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LoginId
        {
            get
            {
                return this.LoginIdField;
            }
            set
            {
                this.LoginIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.UserTest[] Tests
        {
            get
            {
                return this.TestsField;
            }
            set
            {
                this.TestsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LoginUser", Namespace="http://schemas.datacontract.org/2004/07/DataAccess.Models")]
    public partial class LoginUser : object
    {
        
        private int IdField;
        
        private string LoginField;
        
        private string PasswordField;
        
        private ServiceReference1.User UserField;
        
        private int UserIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Login
        {
            get
            {
                return this.LoginField;
            }
            set
            {
                this.LoginField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password
        {
            get
            {
                return this.PasswordField;
            }
            set
            {
                this.PasswordField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.User User
        {
            get
            {
                return this.UserField;
            }
            set
            {
                this.UserField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId
        {
            get
            {
                return this.UserIdField;
            }
            set
            {
                this.UserIdField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsLogin", ReplyAction="http://tempuri.org/IService1/IsLoginResponse")]
        System.Threading.Tasks.Task<bool> IsLoginAsync(string password, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsAdmin", ReplyAction="http://tempuri.org/IService1/IsAdminResponse")]
        System.Threading.Tasks.Task<bool> IsAdminAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Registration", ReplyAction="http://tempuri.org/IService1/RegistrationResponse")]
        System.Threading.Tasks.Task<bool> RegistrationAsync(string password, string login, string fio, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddTest", ReplyAction="http://tempuri.org/IService1/AddTestResponse")]
        System.Threading.Tasks.Task<bool> AddTestAsync(ServiceReference1.Test test);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddQuestion", ReplyAction="http://tempuri.org/IService1/AddQuestionResponse")]
        System.Threading.Tasks.Task<bool> AddQuestionAsync(ServiceReference1.Question question);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RemoveTest", ReplyAction="http://tempuri.org/IService1/RemoveTestResponse")]
        System.Threading.Tasks.Task<bool> RemoveTestAsync(int testId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RemoveQuestion", ReplyAction="http://tempuri.org/IService1/RemoveQuestionResponse")]
        System.Threading.Tasks.Task<bool> RemoveQuestionAsync(int qestionId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IService1Channel : ServiceReference1.IService1, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ServiceReference1.IService1>, ServiceReference1.IService1
    {
        
        /// <summary>
        /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
        /// </summary>
        /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
        /// <param name="clientCredentials">Учетные данные клиента.</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Service1Client() : 
                base(Service1Client.GetDefaultBinding(), Service1Client.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IService1.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), Service1Client.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<bool> IsLoginAsync(string password, string login)
        {
            return base.Channel.IsLoginAsync(password, login);
        }
        
        public System.Threading.Tasks.Task<bool> IsAdminAsync(string login)
        {
            return base.Channel.IsAdminAsync(login);
        }
        
        public System.Threading.Tasks.Task<bool> RegistrationAsync(string password, string login, string fio, string email)
        {
            return base.Channel.RegistrationAsync(password, login, fio, email);
        }
        
        public System.Threading.Tasks.Task<bool> AddTestAsync(ServiceReference1.Test test)
        {
            return base.Channel.AddTestAsync(test);
        }
        
        public System.Threading.Tasks.Task<bool> AddQuestionAsync(ServiceReference1.Question question)
        {
            return base.Channel.AddQuestionAsync(question);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveTestAsync(int testId)
        {
            return base.Channel.RemoveTestAsync(testId);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveQuestionAsync(int qestionId)
        {
            return base.Channel.RemoveQuestionAsync(qestionId);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:56635/Service1.svc");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return Service1Client.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return Service1Client.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IService1,
        }
    }
}
