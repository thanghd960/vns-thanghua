using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using Vns.Core.Commons;
using Vns.Core.Commons.BaseResponse;
using Vns.Core.Commons.Enum;
using Vns.Core.Commons.Paging;
using Vns.Core.Entities;
using Vns.Infrastructure.ModelView.ArticleModel;
using Vns.Infrastructure.Services.IRepository;

namespace Vns.Infrastructure.Services
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly ILogger logger;
        private readonly IBaseRepository<Article> _articleService;
        private readonly IBaseRepository<ArticleTag> _articleTagServices;
        private readonly IBaseRepository<Tag> _tagServices;
        private readonly IBaseRepository<ArticleImage> _articleImageService;
        private readonly IBaseRepository<Image> _imageServices;

        public ArticleRepository(IBaseRepository<Article> articleService,
            IBaseRepository<ArticleTag> articleTagServices,
            IBaseRepository<Tag> tagServices,
            IBaseRepository<Image> imageServices,
            IBaseRepository<ArticleImage> articleImage)
        {
            _articleService = articleService;
            _articleTagServices = articleTagServices;
            _tagServices = tagServices;
            _imageServices = imageServices;
            _articleImageService = articleImage;
        }

        public DetailResponse<int> Approve(int? id)
        {
            var response = new DetailResponse<int>();
            if (id == null) 
            {
                response.Code = MessageCode.NullPointer;
                response.Message = ErrorConstant.Get(MessageCode.NullPointer);
                response.Status = false;
                return response;
            }
            Article article = findById(id);
            if (article == null) 
            {
                response.Data = (int) id;
                response.Code = MessageCode.BE0002;
                response.Message = ErrorConstant.Get(MessageCode.BE0002);
                response.Status = false;
                return response;
            }
            
            article.ApproveEntity();
            try
            {
                _articleService.Update(article);
                _articleService.SaveChanges();
                response.Data = (int) id;
                response.Status = true;
            } catch (Exception exception)
            {
                response.Code = MessageCode.BE0001;
                response.Message = ErrorConstant.GetMessageWithData(MessageCode.BE0001, exception.Message);
                response.Status = false;
            }
            
            return response;
        }

        public DetailResponse<ArticleDto> GetDetail(int? id)
        {
            int articleId = (int) id;
            var response = new DetailResponse<ArticleDto>();

            if (id == null)
            {
                response.Code = MessageCode.NullPointer;
                response.Message = ErrorConstant.Get(MessageCode.NullPointer);
                response.Status = false;
                return response;
            }
            
            Article article = _articleService.Table.Where(p => p.Id == articleId).FirstOrDefault();
            if (article == null)
            {
                response.Code = MessageCode.BE0002;
                response.Message = ErrorConstant.Get(MessageCode.BE0002);
                response.Status = false;
                return response;
            }

            response.Status = true;
            response.Data = mapToArticleResponse(article);
            return response;

        }

        public IPagedList<ArticleDto> GetList(ArticleRequest request)
        {
            if (request.PageIndex < 0) request.PageIndex = 0;
            if (request.PageSize < 1) request.PageSize = 10;

            var articleQuery = _articleService.Table.Where(a => a.CategoryId == request.CategoryId);

            if (EStatus.Actived.Equals(request.Status))
            {
                articleQuery = articleQuery.Where(p => p.Status == true);
            }

            if (EStatus.Inactived.Equals(request.Status))
            {
                articleQuery = articleQuery.Where(p => p.Status == false);
            }

            var total = articleQuery.Count();

            List<Article> articles = articleQuery.OrderByDescending(p => p.ApprovedDate).Skip(request.PageIndex * request.PageSize).Take(request.PageSize).ToList();

            var pagedArticles = articles.ConvertAll(p => mapToArticleResponse(p));

            return new PagedList<ArticleDto>(pagedArticles, request.PageIndex, request.PageSize, total);
        }

        public DetailResponse<int> Inactive(int? id)
        {
            try
            {
                int articleId = (int)id;
                Article article = findById(articleId);
                if (article == null)
                {
                    return new DetailResponse<int>()
                    {
                        Status = false,
                        Code = MessageCode.NullPointer,
                        Message = ErrorConstant.Get(MessageCode.NullPointer),
                        Data = articleId
                    };

                }

                article.Inactive();
                _articleService.Update(article);

                return new DetailResponse<int>()
                {
                    Status = true,
                    Data = articleId
                };

            } catch(VnsException exception)
            {
                logger.LogDebug(exception.ToString());
                return new DetailResponse<int>()
                {
                    Status = false,
                    Code = MessageCode.Exception,
                    Message = ErrorConstant.GetMessageWithData(MessageCode.Exception, exception.Message)
                };
            }
        }

        public DetailResponse<ArticleDto> Insert(ArticleDto request)
        {
            var article = new Article()
            {
                Title = request.Title,
                DescriptionShort = request.Description,
                Content = request.Content,
                CategoryId = (int) request.Category
            };
            article.ApproveEntity();
        }

        public DetailResponse<ArticleDto> Update(ArticleDto request)
        {
            throw new NotImplementedException();
        }

        private Article findById(int? id){
            return _articleService.GetById(id);
        }

        private ArticleDto mapToArticleResponse(Article article){
            ArticleDto response = new ArticleDto()
            {
                Id = article.Id,
                Content = article.Content,
                Description = article.DescriptionShort,
                Title = article.Title,
                FriendlyUrl = "",
                Tags = new List<Tag>(),
                Images = new List<Image>()
            };

            try {
                response.FriendlyUrl = FriendlyUrlHelper.GetFriendlyTitle(article.Title, false, article.Title.Length);
            } catch(VnsException exception) {
                logger.LogDebug(exception.ToString());
            }

            var imgIds = _articleImageService.Table.Where(p => p.Status == true && p.ArticleId == article.Id).ToList();
            if (imgIds.Count > 0){
                imgIds.ForEach(img => {
                    response.Images.Add(_imageServices.Table.Where(p => p.Id == img.ImageId).FirstOrDefault());
                });
            }

            var tagIds = _articleTagServices.Table.Where(p => p.Status == true && p.ArticleId == article.Id).ToList();
            if (tagIds.Count > 0) {
                tagIds.ForEach(tag => {
                    response.Tags.Add(_tagServices.Table.Where(p => p.Id == tag.TagId).FirstOrDefault());
                });
            }

            return response;
        }
    }
}