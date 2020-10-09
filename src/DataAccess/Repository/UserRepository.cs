using DataAccess.Context;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repository
{
    public class UserRepository:BaseRepository<User>
    {
        public UserRepository(TestsContext context) : base(context) { }
    }
}
