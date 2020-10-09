using DataAccess.Context;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class QuestionRepository:BaseRepository<Question>
    {
        public QuestionRepository(TestsContext context) : base(context) { }
        public override async Task<IReadOnlyCollection<Question>> GetAllAsync()
        {
            return await this.Entities
                .Include(u => u.Test)
                .Include(x=>x.Answers)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public override async Task<IReadOnlyCollection<Question>> FindByConditionAsync(Expression<Func<Question, bool>> predicat)
        {
            return await this.Entities
                .Include(u => u.Test)
                .Include(x=>x.Answers)
                .Where(predicat)
                .ToListAsync()
                .ConfigureAwait(false);
        }
    }
}
