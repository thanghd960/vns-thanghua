using System;
using Microsoft.AspNetCore.Mvc;
using Vns.Infrastructure.Services.IRepository;

namespace Vns.Web.Components
{
    public class DetailArticleViewComponent : ViewComponent
    {
        private readonly IArticleRepository _articleRepository;

        public DetailArticleViewComponent(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public IViewComponentResult Invoke(int id)
        {
            var result = _articleRepository.GetDetail(id);

            return View(result);
        }
    }
}
