﻿using System;
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
        private IBaseRepository<Image> _image;
        private IBaseRepository<Tag> _tag;

        private IBaseRepository<Category> _category;

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

        public IBaseRepository<Image> Image 
        {
            get
            {
                return _image ?? (_image = new BaseRepository<Image>(_dbContext));
            }    
        }
        
        public IBaseRepository<Tag> Tag 
        {
            get
            {
                return _tag ?? (_tag = new BaseRepository<Tag>(_dbContext));
            }   
        }

        public IBaseRepository<Category> Category 
        {
            get
            {
                return _category ?? (_category = new BaseRepository<Category>(_dbContext));
            }       
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
