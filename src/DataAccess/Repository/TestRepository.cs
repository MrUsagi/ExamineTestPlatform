using DataAccess.Context;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repository
{
    public class TestRepository:BaseRepository<Test>
    {
        public TestRepository(TestsContext context) : base(context) { }
    }
}
