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
        private readonly IUnitOfWork _unitOfWork;
        public ArticleRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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
                _unitOfWork.Article.Update(article);
                _unitOfWork.Article.SaveChanges();
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
            Article article = _unitOfWork.Article.Table.Where(p => p.Id == articleId).FirstOrDefault();
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

            var articleQuery = _unitOfWork.Article.Table;

            if (request.CategoryId != null)
            {
                articleQuery = articleQuery.Where(p => p.CategoryId == request.CategoryId);
            }
            
            if (EStatus.Actived.Equals(request.Status))
            {
                articleQuery = articleQuery.Where(p => p.Status == true);
            }

            if (EStatus.Inactived.Equals(request.Status))
            {
                articleQuery = articleQuery.Where(p => p.Status == false);
            }

            if (request.IsFeatured)
            {
                articleQuery = articleQuery.Where(p => p.IsFeature == true);
            }

            if (request.IsTrending)
            {
                articleQuery = articleQuery.Where(p => p.IsTrendingNow == true);
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
                _unitOfWork.Article.Update(article);
                return new DetailResponse<int>()
                {
                    Status = true,
                    Data = articleId
                };

            } catch(VnsException exception)
            {
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
            var result = new DetailResponse<ArticleDto>();
            result.Data = request;

            try 
            {
                var image = new Image()
                {
                    Url = request.Images.Url,
                    ImageDescription = ""
                };
                _unitOfWork.Image.Insert(image);
                _unitOfWork.Image.SaveChanges();

                var article = new Article()
                {
                    Title = request.Title,
                    DescriptionShort = request.Description,
                    Content = request.Content,
                    CategoryId = request.CategoryId,
                    ImageId = image.Id,
                    IsTrendingNow = request.IsTrending,
                    IsFeature = request.IsFeatured
                };

                article.ApproveEntity();
                _unitOfWork.Article.Insert(article);
                _unitOfWork.Article.SaveChanges();



                var tags = request.Tags;

                if (tags.Count > 0)
                {
                    foreach (var tag in tags)
                    {
                        _unitOfWork.Tag.Insert(tag);
                        _unitOfWork.Tag.SaveChanges();
                        _unitOfWork.ArticleTag.Insert(new ArticleTag()
                        {
                            TagId = tag.Id,
                            ArticleId = article.Id
                        });
                        _unitOfWork.ArticleTag.SaveChanges();
                        
                    }
                }
                
                result.Status = true;
            } 
            catch (Exception exception)
            {
                result.Status = false;
                result.Code = MessageCode.Exception;
                result.Message = ErrorConstant.GetMessageWithData(MessageCode.Exception, exception.Message);
            }
            return result;
        }

        public DetailResponse<int> Remove(int? id)
        {
            var res = new DetailResponse<int>()
            {
                Status = true,
                Data = (int)id
            };
            try
            {
                Article article = findById(id);
                _unitOfWork.Article.Delete(article);
                _unitOfWork.Article.SaveChanges();
            }
            catch (Exception ex)
            {
                res.Status = false;
                res.Message = ex.Message;
            }

            return res;
            
        }

        public DetailResponse<ArticleDto> Update(ArticleDto request)
        {
            throw new NotImplementedException();
        }

        private Article findById(int? id){
            return _unitOfWork.Article.GetById(id);
        }

        private ArticleDto mapToArticleResponse(Article article){
            ArticleDto response = new ArticleDto()
            {
                Id = article.Id,
                Content = article.Content,
                Description = article.DescriptionShort,
                Title = article.Title,
                Tags = new List<Tag>(),
                Status = article.Status,
                Images = _unitOfWork.Image.Table.Where(i => i.Id == article.Id).First()
            };

            try {
                response.FriendlyUrl = FriendlyUrlHelper.GetFriendlyTitle(article.Title, false, article.Title.Length);
            } catch(VnsException) { }

            var tagIds = _unitOfWork.ArticleTag.Table.Where(p => p.Status == true && p.ArticleId == article.Id).ToList();
            if (tagIds.Count > 0) {
                tagIds.ForEach(tag => {
                    response.Tags.Add(_unitOfWork.Tag.Table.Where(p => p.Id == tag.TagId).FirstOrDefault());
                });
            }

            return response;
        }
    }
}