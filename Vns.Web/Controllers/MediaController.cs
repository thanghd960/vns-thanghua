using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vns.Web.Controllers
{
    public class MediaController : Controller
    {
        private readonly IWebHostEnvironment _env;

        public MediaController(IWebHostEnvironment env)
        {
            _env = env;
        }

        [HttpPost]
        public async Task<JsonResult> UploadImage(IFormFile source)
        {
            try
            {

                string filename = ContentDispositionHeaderValue.Parse(source.ContentDisposition).FileName.Trim('"');
                string path = GetPathAndFilename(filename);

                filename = this.EnsureCorrectFilename(filename);

                using (FileStream output = System.IO.File.Create(path))
                {
                    await source.CopyToAsync(output);
                }

                return Json(filename);
            } catch (Exception ex)
            {
                return Json(ex.Message);
            }
            
        }

        private string EnsureCorrectFilename(string filename)
        {
            if (filename.Contains("\\"))
                filename = filename.Substring(filename.LastIndexOf("\\") + 1);

            return filename;
        }

        private string GetPathAndFilename(string filename)
        {
            string seqFileName = "vns" + "_" + Guid.NewGuid().ToString()+ filename;
            return _env.WebRootPath + "\\uploads\\" + seqFileName;
            
        }

    }
}
