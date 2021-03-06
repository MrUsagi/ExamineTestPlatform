﻿using DataAccess.Context;
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
    public class UserRepository:BaseRepository<User>
    {
        public UserRepository(TestsContext context) : base(context) { }
        public override async Task<IReadOnlyCollection<User>> GetAllAsync()
        {
            return await this.Entities
                .Include(u => u.Login)
                .Include(x => x.Tests)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public override async Task<IReadOnlyCollection<User>> FindByConditionAsync(Expression<Func<User, bool>> predicat)
        {
            return await this.Entities
                .Include(u => u.Tests)
                .Include(x => x.Login)
                .Where(predicat)
                .ToListAsync()
                .ConfigureAwait(false);
        }
    }
}
