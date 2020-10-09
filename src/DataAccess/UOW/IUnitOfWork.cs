using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.UOW
{
    public interface IUnitOfWork
    {
        LoginUserRepository Logins { get; }
        UserRepository Users { get; }
    }
}
