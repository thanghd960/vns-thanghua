using System;
using Vns.Core.Entities;

namespace Vns.Infrastructure.Services.IRepository
{
    public interface IUnitOfWork
    {
        IBaseRepository<Article> Article { get; }
        IBaseRepository<ArticleTag> ArticleTag { get; }
        void Commit();

    }
}
