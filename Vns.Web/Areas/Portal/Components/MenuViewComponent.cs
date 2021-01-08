using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vns.Infrastructure.Services.IRepository;

namespace Vns.Web.Areas.Portal.Components
{
    public class MenuViewComponent: ViewComponent
    {
        private readonly IMenuRepository _menuRepository;

        public MenuViewComponent(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }
        public IViewComponentResult Invoke()
        {
            return View(_menuRepository.getMenuAdmin());
        }
    }
}
