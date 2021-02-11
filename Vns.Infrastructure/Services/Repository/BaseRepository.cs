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
        private readonly DbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        public IQueryable<TEntity> Table => _dbSet;

        public TEntity GetById(params object[] ids)
        {
            return _dbSet.Find(ids);
        }

        public virtual IQueryable<TEntity> GetAll(params string[] includes)
        {
            return Get(null, null, includes);
        }

        public virtual IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> @where = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params Expression<Func<TEntity, object>>[] navigationProperties)
        {
            IQueryable<TEntity> dbQuery = this.Table;
            //Apply eager loading
            dbQuery = navigationProperties.Aggregate(dbQuery, (current, navigationProperty) => current.Include(navigationProperty));
            if (where != null) dbQuery = dbQuery.Where(where);
            return orderBy != null ? orderBy(dbQuery) : dbQuery;
        }

        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params string[] includeProperties)
        {
            var query = Table;
            if (filter != null)
            {
                query = query.Where(filter);
            }

            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return orderBy != null ? orderBy(query) : query;
        }

        public async Task Insert(TEntity entity)
        {
            await _dbContext.AddAsync(entity);
        }

        public List<TEntity> InsertRange(IEnumerable<TEntity> listEntity)
        {
            return listEntity.Select(entity =>
            {
                _dbSet.Add(entity);
                return entity;
            }).ToList();
        }

        public void Update(TEntity entity, params string[] changedProes)
        {
            if (changedProes == null)
            {
                changedProes = new string[] { };
            }

            _dbSet.Attach(entity);
            if (changedProes.Any())
            {
                //Only change some properties
                foreach (string propertyName in changedProes)
                {
                    _dbContext.Entry(entity).Property(propertyName).IsModified = true;
                }
            }
            else
            {
                _dbContext.Entry(entity).State = EntityState.Modified;
            }
        }

        public void Delete(TEntity entity)
        {
            try
            {
                if (_dbContext.Entry(entity).State == EntityState.Detached)
                {
                    _dbSet.Attach(entity);
                }
                _dbSet.Remove(entity);
            }
            catch (Exception)
            {
                RefreshEntity(entity);
                throw;
            }
        }

       

        public virtual int Count(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? Table.Count() : Table.Count(filter);
        }

        public virtual bool Any(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? Table.AsNoTracking().Any() : Table.AsNoTracking().Any(filter);
        }


        public virtual void RefreshEntity(TEntity entityToReload)
        {
            _dbContext.Entry(entityToReload).Reload();
        }

        public int Update(Expression<Func<TEntity, bool>> filterExpression, Expression<Func<TEntity, TEntity>> updateExpression)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteRangeAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public int DeleteRange(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public int DeleteRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }
    }
}
