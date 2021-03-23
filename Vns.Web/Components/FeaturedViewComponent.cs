using System;
using Microsoft.AspNetCore.Mvc;
using Vns.Infrastructure.Services.IRepository;

namespace Vns.Web.Components
{
    public class FeaturedViewComponent: ViewComponent
    {
        private readonly IArticleRepository _articleRepository;

        public FeaturedViewComponent(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }
        public IViewComponentResult Invoke()
        {
            var result = _articleRepository.GetList(new Infrastructure.ModelView.ArticleModel.ArticleRequest()
            {
                Status = Core.Commons.Enum.EStatus.Actived,
                IsFeatured = true
            });
            
            return View(result);
        }
    }
}
