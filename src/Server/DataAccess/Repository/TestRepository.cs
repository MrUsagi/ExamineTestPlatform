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
    public class TestRepository:BaseRepository<Test>
    {
        public TestRepository(TestsContext context) : base(context) { }
        public override async Task<IReadOnlyCollection<Test>> GetAllAsync()
        {
            return await this.Entities
                .Include(q => q.Questions)
                .Include(x=>x.Users)
                .Where(x => !x.IsRemove)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public override async Task<IReadOnlyCollection<Test>> FindByConditionAsync(Expression<Func<Test, bool>> predicat)
        {
            return await this.Entities
                .Include(q => q.Questions)
                .Include(x=>x.Users)
                .Where(predicat)
                .Where(x => !x.IsRemove)
                .ToListAsync()
                .ConfigureAwait(false);
        }
    }
}
