using System;
using Vns.Core.Entities;
using Vns.Infrastructure.Data;
using Vns.Infrastructure.Services.IRepository;

namespace Vns.Infrastructure.Services.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private VnstyleDbContext _dbContext;

        private IBaseRepository<Article> _article;
        private IBaseRepository<ArticleTag> _articleTag;


        public UnitOfWork(VnstyleDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IBaseRepository<Article> Article
        {
            get
            {
                return _article ?? (_article = new BaseRepository<Article>(_dbContext));
            }
        }

        public IBaseRepository<ArticleTag> ArticleTag
        {
            get
            {
                return _articleTag ?? (_articleTag = new BaseRepository<ArticleTag>(_dbContext));
            }
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
