using DataAccess.Context;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repository
{
    public class AnswerRepository:BaseRepository<Answer>
    {
        public AnswerRepository(TestsContext context) : base(context) { }
    }
}
