﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vns.Web.Areas.Portal.Controllers
{
    public class HomeController : BaseController
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
