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
    public class AnswerRepository:BaseRepository<Answer>
    {
        public AnswerRepository(TestsContext context) : base(context) { }
        public override async Task<IReadOnlyCollection<Answer>> GetAllAsync()
        {
            return await this.Entities
                .Include(q => q.Question)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public override async Task<IReadOnlyCollection<Answer>> FindByConditionAsync(Expression<Func<Answer, bool>> predicat)
        {
            return await this.Entities
                .Include(q => q.Question)
                .Where(predicat)
                .ToListAsync()
                .ConfigureAwait(false);
        }
    }
}
