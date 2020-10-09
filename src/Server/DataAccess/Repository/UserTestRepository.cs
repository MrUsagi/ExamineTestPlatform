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
    public class UserTestRepository:BaseRepository<UserTest>
    {
        public UserTestRepository(TestsContext context) : base(context) { }
        public override async Task<IReadOnlyCollection<UserTest>> GetAllAsync()
        {
            return await this.Entities
                .Include(u => u.Test)
                .Include(x => x.User)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public override async Task<IReadOnlyCollection<UserTest>> FindByConditionAsync(Expression<Func<UserTest, bool>> predicat)
        {
            return await this.Entities
                .Include(u => u.Test)
                .Include(x => x.User)
                .Where(predicat)
                .ToListAsync()
                .ConfigureAwait(false);
        }
    }
}
