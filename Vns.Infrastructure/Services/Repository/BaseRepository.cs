using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vns.Core.Entities;
using Vns.Infrastructure.Data;
using Vns.Infrastructure.Services.IRepository;
namespace Vns.Infrastructure.Services.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        internal VnstyleDbContext dbContext;
        internal DbSet<TEntity> dbSet;

        public BaseRepository(VnstyleDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<TEntity>();

        }

        public async Task Delete(TEntity entity)
        {
            dbContext.Set<TEntity>().Remove(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            TEntity entity = dbContext.Set<TEntity>().SingleOrDefault(e => e.Id == id && e.Status == true);
            if (entity == null)
            {
                throw new Exception("Id not found");
            }
            dbContext.Set<TEntity>().Remove(entity);
            await dbContext.SaveChangesAsync();

        }

        public Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetByID(object id)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<TEntity> GetWithRawSql(string query, params object[] parameters)
        {
            return dbSet.FromSqlRaw(query, parameters).ToList();
        }


        public Task Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(TEntity entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
