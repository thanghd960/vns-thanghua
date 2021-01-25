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
        void Delete(TEntity entityToDelete);
        void DeleteById(int id);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
        TEntity GetByID(object id);
        IEnumerable<TEntity> GetWithRawSql(string query, params object[] parameters);
        Task Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
    }

}
