using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Vns.Core.Entities;

namespace Vns.Infrastructure.Services.IRepository
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task Delete(TEntity entityToDelete);
        Task Delete(int id);
        Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
        Task<TEntity> GetByID(object id);
        IEnumerable<TEntity> GetWithRawSql(string query, params object[] parameters);
        Task Insert(TEntity entity);
        Task Update(TEntity entityToUpdate);
    }

}
