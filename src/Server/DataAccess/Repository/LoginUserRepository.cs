using DataAccess.Context;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repository
{
    public class LoginUserRepository:BaseRepository<LoginUser>
    {
        public LoginUserRepository(TestsContext context):base(context) {}
    }
}
