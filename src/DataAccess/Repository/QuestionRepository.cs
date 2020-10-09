using DataAccess.Context;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repository
{
    public class QuestionRepository:BaseRepository<Question>
    {
        public QuestionRepository(TestsContext context) : base(context) { }
    }
}
