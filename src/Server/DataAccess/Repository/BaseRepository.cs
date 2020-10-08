using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Repository.Interfaces;
using DataAccess.Context;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Repository
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DbSet<TEntity> _entities;
        private TestsContext _context;
        protected DbSet<TEntity> Entities => this._entities ??= _context.Set<TEntity>();
        protected BaseRepository(TestsContext context)
        {
            _context = context;
        }
        public virtual async Task CreateAsync(TEntity entity)
        {
            await Entities.AddAsync(entity).ConfigureAwait(false);
        }

        public virtual async Task<IReadOnlyCollection<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> predicat)
        {
            return await this.Entities.Where(predicat).ToListAsync().ConfigureAwait(false);
        }

        public virtual async Task<IReadOnlyCollection<TEntity>> GetAllAsync()
        {
            return await this.Entities.ToListAsync().ConfigureAwait(false);
        }
    }
}
