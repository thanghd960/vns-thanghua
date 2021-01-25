using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vns.Core.Entities;
using Vns.Infrastructure.Services.IRepository;
using Vns.Infrastructure.Services.Repository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vns.Web.Areas.Portal.Controllers
{
    public class ArticleController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;

        public ArticleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int id) {
            return View();
        }

        public IActionResult Create()
        {
            var article = new Article()
            {
                Title = "Những câu STT hay về hình xăm (Tattoo) ý nghĩa",
                DescriptionShort = "Xăm hình vốn là một nghệ thuật có từ lâu đời và được giới trẻ ngày nay yêu thích. Đằng sau một hình xăm luôn ẩn chứa nhiều ý nghĩa và kỉ niệm buồn vui của người xăm hình. Phong trào xăm hình ngày càng phổ biến và phát triển mạnh mẽ, xăm hình không chỉ làm đẹp mà còn thể hiện phần nào tính cách của chủ nhân. Dưới đây là những câu stt hình xăm hay và ý  nghĩa, mời bạn xem qua. ",
                IsFeature = true,
                IsHomePage = true,
                IsTrendingNow = true,
                Content = "Xăm hình là tốt hay xấu? 1. Nhân cách không nằm ở hình xăm",
                Index = 1,
                ApprovedBy = "thanghua",
                CategoryId = 1,
                View = 0
            };
            _unitOfWork.Article.Insert(article);
            _unitOfWork.Commit();
            return View();
        }


    }
}
