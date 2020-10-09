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
    public class LoginUserRepository:BaseRepository<LoginUser>
    {
        public LoginUserRepository(TestsContext context):base(context) {}
        public override async Task<IReadOnlyCollection<LoginUser>> GetAllAsync()
        {
            return await this.Entities
                .Include(u => u.User)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public override async Task<IReadOnlyCollection<LoginUser>> FindByConditionAsync(Expression<Func<LoginUser, bool>> predicat)
        {
            return await this.Entities
                .Include(u => u.User)
                .Where(predicat)
                .ToListAsync()
                .ConfigureAwait(false);
        }
    }
}
