using System;
using Vns.Core.Entities;

namespace Vns.Infrastructure.Services.IRepository
{
    public interface IUnitOfWork
    {
        IBaseRepository<Article> Article { get; }
        IBaseRepository<ArticleTag> ArticleTag { get; }
        IBaseRepository<Tag> Tag { get; }
        IBaseRepository<Image> Image { get; }
        void Commit();

    }
}
