using System;
using Microsoft.AspNetCore.Mvc;
using Vns.Infrastructure.Services.IRepository;

namespace Vns.Web.Components
{
    public class TrendingViewComponent : ViewComponent
    {
        private readonly IArticleRepository _articleRepository;

        public TrendingViewComponent(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }
        public IViewComponentResult Invoke()
        {
            var result = _articleRepository.GetList(new Infrastructure.ModelView.ArticleModel.ArticleRequest()
            {
                Status = Core.Commons.Enum.EStatus.Actived,
                IsTrending = true
            });

            return View(result);
        }
    }
}
