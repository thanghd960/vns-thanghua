using Microsoft.AspNetCore.Mvc;
using Vns.Core.Commons;
using Vns.Core.Commons.BaseResponse;
using Vns.Core.Commons.Enum;
using Vns.Core.Commons.Paging;
using Vns.Infrastructure.ModelView.ArticleModel;
using Vns.Infrastructure.Services.IRepository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vns.Web.Areas.Portal.Controllers
{
    public class ArticleController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IArticleRepository _articleRepository;

        public ArticleController(IUnitOfWork unitOfWork, IArticleRepository articleRepository)
        {
            _unitOfWork = unitOfWork;
            _articleRepository = articleRepository;
        }

        // GET: /<controller>/
        public IActionResult Index(string search = "", int pageIndex = 0)
        {
            ViewData["Title"] = "Bài Viết";
            ArticleRequest request = new ArticleRequest()
            {
                Keyword = search == "" ? null : search,
                PageIndex = pageIndex,
                CategoryId = null,
                Status = EStatus.All
            };
            IPagedList<ArticleDto> articles = _articleRepository.GetList(request);
            
            return View(articles);
        }

        public IActionResult Detail(int? id) {
            ViewData["Title"] = "Bài Viết";
            ViewData["Action"] = "Chi tiết";
            var article = _articleRepository.GetDetail(id);
            return View(article);
        }

        public IActionResult Create()
        {
            ViewData["Title"] = "Bài Viết";
            ViewData["Action"] = "Tạo mới";
            return View();
        }

        [HttpGet]
        public JsonResult GetCategories()
        {
            return Json(_unitOfWork.Category.GetAll());
        }


        [HttpPost]
        public JsonResult CreateArticle(ArticleDto article)
        {
            DetailResponse<ArticleDto> result = new DetailResponse<ArticleDto>();
            if (article.Title == null)
            {
                result = new DetailResponse<ArticleDto>
                {
                    Status = false,
                    Data = article,
                    Message = ErrorConstant.Get(MessageCode.BE0003)

                };
                return Json(result);
            }

            if (article.Description == null)
            {
                result = new DetailResponse<ArticleDto>
                {
                    Status = false,
                    Data = article,
                    Message = ErrorConstant.Get(MessageCode.BE0004)

                };
                return Json(result);
            }
    
            result = _articleRepository.Insert(article);
            return Json(result);
        }

        [HttpPost]
        public JsonResult ActiveArticle(int? id)
        {
            DetailResponse<int> response = new DetailResponse<int>();
            response = _articleRepository.Approve(id);
            return Json(response);
        }

        [HttpPost]
        public JsonResult DeleteArticle(int? id)
        {
            return Json(_articleRepository.Remove(id));
        }
    }
}
