using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UOW
{
    public interface IUnitOfWork
    {
        public AnswerRepository Answers { get; }
        public LoginUserRepository Logins { get; }
        public QuestionRepository Questions { get; }
        public TestRepository Tests { get; }
        public UserRepository Users { get; }
        public UserTestRepository UsersTests { get; }
        public Task SaveAsync();
    }
}
