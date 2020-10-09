using DataAccess.Context;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TestsContext _context;
        public UnitOfWork(TestsContext context,
            AnswerRepository answer,
            LoginUserRepository login,
            QuestionRepository question,
            TestRepository test,
            UserRepository user,
            UserTestRepository userTest)
        {
            _context = context;
            Answers = answer;
            Logins = login;
            Questions = question;
            Tests = test;
            Users = user;
            UsersTests = UsersTests;
        }
        public AnswerRepository Answers { get; }

        public LoginUserRepository Logins { get; }

        public QuestionRepository Questions { get; }

        public TestRepository Tests { get; }

        public UserRepository Users { get; }

        public UserTestRepository UsersTests { get; }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
