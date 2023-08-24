using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Application.Interfaces.Repository;
using OnionArchitecture.Domain.General;
using OnionArchitecture.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Persistence.Repositories
{
    public class GeneralRepository<TEntity, TContext> : IGeneralRepository<TEntity>
        where TEntity : BaseEntity
        where TContext : DbContext, new()
    {

        public async Task Delete(TEntity item)
        {
            await using TContext dbContext = new TContext();
            var deletedEntity = dbContext.Entry(item);
            deletedEntity.State = EntityState.Deleted;
            await dbContext.SaveChangesAsync();
        }

        public async Task<TEntity> GetById(long itemId)
        {
            await using TContext dbContext = new TContext();
            return await dbContext.Set<TEntity>().AsNoTracking().SingleOrDefaultAsync(d => d.Id == itemId);
        }

        public async Task<IEnumerable<TEntity>> GetList(System.Linq.Expressions.Expression<Func<TEntity, bool>>? filter = null)
        {
            await using TContext dbContext = new TContext();
            return filter == null
                      ? await dbContext.Set<TEntity>().AsNoTracking().ToListAsync()
                      : await dbContext.Set<TEntity>().Where(filter).AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> Save(TEntity item)
        {
            await using TContext dbContext = new TContext();
            var addedEntity = dbContext.Entry(item);
            addedEntity.State = EntityState.Added;
            await dbContext.SaveChangesAsync();
            return item;
        }

        public async Task<TEntity> Update(TEntity item)
        {
            await using TContext dbContext = new TContext();
            var updatedEntity = dbContext.Entry(item);
            updatedEntity.State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
            return item;
        }
    }
}
