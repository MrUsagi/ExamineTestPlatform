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
        private static UnitOfWork _instance;
        private UnitOfWork()
        {
            _context = TestsContext.GetContext();
            Answers = new AnswerRepository(_context);
            Logins = new LoginUserRepository(_context);
            Questions = new QuestionRepository(_context);
            Tests = new TestRepository(_context);
            Users = new UserRepository(_context);
            UsersTests = new UserTestRepository(_context);
        }
        public static UnitOfWork GetInstance() {
            if (_instance == null)
                _instance = new UnitOfWork();
            return _instance;
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
