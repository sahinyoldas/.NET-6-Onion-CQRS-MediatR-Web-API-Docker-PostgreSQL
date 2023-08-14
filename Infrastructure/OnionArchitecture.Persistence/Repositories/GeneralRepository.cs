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
    public class GeneralRepository<TEntity> : IGeneralRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ApplicationDbContext dbContext;

        public GeneralRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Delete(TEntity item)
        {
            var deletedEntity = dbContext.Entry(item);
            deletedEntity.State = EntityState.Deleted;
            await dbContext.SaveChangesAsync();
        }

        public async Task<TEntity> GetById(long itemId)
        {
            return await dbContext.Set<TEntity>().SingleOrDefaultAsync(d => d.Id == itemId);
        }

        public async Task<IEnumerable<TEntity>> GetList(System.Linq.Expressions.Expression<Func<TEntity, bool>>? filter = null)
        {
            return filter == null
                      ? await dbContext.Set<TEntity>().ToListAsync()
                      : await dbContext.Set<TEntity>().Where(filter).ToListAsync();
        }

        public async Task<TEntity> Save(TEntity item)
        {
            var addedEntity = dbContext.Entry(item);
            addedEntity.State = EntityState.Added;
            await dbContext.SaveChangesAsync();
            return item;
        }

        public async Task<TEntity> Update(TEntity item)
        {
            var updatedEntity = dbContext.Entry(item);
            updatedEntity.State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
            return item;
        }
    }
}
