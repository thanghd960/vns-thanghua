using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vns.Core.Commons.WebHelper;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vns.Web.Controllers
{
    public class MediaController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public MediaController(IWebHostEnvironment env, IHttpContextAccessor httpContextAccessor)
        {
            _env = env;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost]
        public async Task<JsonResult> UploadImage(IFormFile source)
        {
            var domain = _httpContextAccessor.HttpContext.Request.Host.ToString();
            return Json(Path.Combine(domain, await FuncUploadImage(source)));
        }


        [HttpPost]
        public async Task<JsonResult> EditorUpload(IFormFile upload)
        {
            var url = $"{await FuncUploadImage(upload)}";
            return Json(new { uploaded = true, url });
        }


        private async Task<string> FuncUploadImage(IFormFile source)
        {
            var domain = _httpContextAccessor.HttpContext.Request.Host.ToString();

            string noImage = Path.Combine(domain, "/admin/images/no-images.jpeg");

            if (source == null)
            {
                return noImage;
            }
            

            string urlImage;

            try
            {
                string wwwPath = _env.WebRootPath;
                string contentPath = _env.ContentRootPath;

                string folderUpload = "uploads";

                string path = Path.Combine(_env.WebRootPath, folderUpload);

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }


                var extention = Path.GetExtension(Path.GetFileName(source.FileName));
                var fileName = CombineFileName(extention);

                var filePath = Path.Combine(path, fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await source.CopyToAsync(fileStream);
                }

                urlImage = "/" + folderUpload + "/" + fileName;

            }
            catch (Exception) { urlImage = noImage ; }

            return urlImage;
        }



        private string CombineFileName(string extention)
        {
            return "vns" + "-" + Guid.NewGuid().ToString() + DateTime.Now.ToString("yyyyMMddHHmmss") + extention;
        }

    }
}
