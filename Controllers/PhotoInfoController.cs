using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PhotoInfo.Models;
using System.Diagnostics;
using ExifPhotoReader;
using System.Drawing;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace PhotoInfo.Controllers
{
    public class PhotoInfoController : Controller
    {
        private readonly ILogger<PhotoInfoController> _logger;

        public PhotoInfoController(ILogger<PhotoInfoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UploadImage(IFormFile file)
        {

            if (file != null && file.Length > 0)
            {
                Image image = Image.FromStream(file.OpenReadStream(), true, true);

                ExifImageProperties exifImage = ExifPhoto.GetExifDataPhoto(image);

                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    string imageBase64 = Convert.ToBase64String(fileBytes);
                    ViewBag.imageBase64 = String.Format("data:image/gif;base64,{0}", imageBase64);
                }
                
                return View("Index", exifImage);
            }

            return View("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
