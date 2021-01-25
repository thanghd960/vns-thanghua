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

        public void Delete(TEntity entity)
        {
            dbContext.Set<TEntity>().Remove(entity);
            dbContext.SaveChanges();
        }

        public void DeleteById(int id)
        {
            TEntity entity = dbContext.Set<TEntity>().SingleOrDefault(e => e.Id == id && e.Status == true);
            if (entity == null)
            {
                throw new Exception("Id not found");
            }
            dbContext.Set<TEntity>().Remove(entity);
            dbContext.SaveChanges();

        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }


            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }

        }

        public virtual TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> GetWithRawSql(string query, params object[] parameters)
        {
            return dbSet.FromSqlRaw(query, parameters).ToList();
        }


        public async Task Insert(TEntity entity)
        {
            await dbContext.AddAsync(entity);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            dbContext.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}
