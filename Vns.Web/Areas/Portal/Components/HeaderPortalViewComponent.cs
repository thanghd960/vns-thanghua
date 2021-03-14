using System;
using Microsoft.AspNetCore.Mvc;

namespace Vns.Web.Areas.Portal.Components
{
    public class HeaderPortalViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke(string pageName, string actionName)
        {
            ViewData["PageName"] = pageName;
            ViewData["Action"] = actionName;
            return View();
        }
    }
}
