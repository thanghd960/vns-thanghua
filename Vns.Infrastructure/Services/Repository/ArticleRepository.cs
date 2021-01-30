using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Vns.Core.Commons;
using Vns.Core.Entities;
using Vns.Infrastructure.ModelView.ArticleModelView;
using Vns.Infrastructure.Services.IRepository;

namespace Vns.Infrastructure.Services {
    public class ArticleRepository : IArticleRepository
    {
        private readonly ILogger logger;
        private IBaseRepository<Article> _articleService;
        private IBaseRepository<ArticleTag> _articleTagServices;
        private IBaseRepository<Tag> _tagServices;
        private IBaseRepository<Image> _imageServices;

        public ResponseData<int> approveArticle(int id)
        {
            var response = new ResponseData<int>();
            var article = _articleService.GetByID(id);
            if (article == null)
            {
                response.Data = null;
                response.Result = new ResultStatus()
                {
                    Code = eMessageCode.ERROR_000002,
                    Message = ErrorConstant.GetMessageWithData(eMessageCode.ERROR_000002, id.ToString()),
                    Status = false
                };
                return response;
            }
            
            article.ApproveEntity();
            _articleService.Update(article);

            response.Data = new List<int>(){ id };
            response.Result = new ResultStatus() 
            {
                Code = eMessageCode.SUCCESS_000001,
                Message = ErrorConstant.GetMessageWithData(eMessageCode.SUCCESS_000001, id.ToString()),
                Status = true
            };

            return response;
        }

        public ResponseData<int> deleteArticle(int id)
        {
            var article = _articleService.GetByID(id);
            var response = new ResponseData<int>();
            response.Data = new List<int>() { id } ;
            if (article == null)
            {   
                response.Result = new ResultStatus()
                {
                    Code = eMessageCode.ERROR_000002,
                    Message = ErrorConstant.GetMessageWithData(eMessageCode.ERROR_000002, id.ToString()),
                    Status = false
                };
            } else {
                try {
                    article.Inactive();
                    _articleService.Update(article);
                    response.Result = new ResultStatus() 
                    {
                        Code = eMessageCode.SUCCESS_000002,
                        Message = ErrorConstant.GetMessageWithData(eMessageCode.SUCCESS_000002, id.ToString()),
                        Status = true
                    };
                    return response;
                } catch (Exception ex){
                    response.Result = new ResultStatus() 
                    {
                        Code = eMessageCode.SYSTEM_ERROR,
                        Message = ErrorConstant.GetMessageWithData(eMessageCode.SYSTEM_ERROR, ex.Message),
                        Status = true
                    };
                }
            }
            return response;

        }

        public ResponseData<ArticleModelView> getArticleById(int id)
        {
            IPaged
            var article = _articleService.GetByID(id);
            if (article == null){
                return null;
            }
        
            return null;
        }

        public ResponseData<ArticleModelView> insertArticle(ArticleModelView request)
        {
            throw new NotImplementedException();
        }

        public ResponseData<ArticleModelView> updateArticle(ArticleModelView request)
        {
            throw new NotImplementedException();
        }
    }
}