﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace Project.UI.Helpers
{
    public class ImageHelper
    {
        private readonly IWebHostEnvironment _webhost;

        public ImageHelper(IWebHostEnvironment webhost)
        {
            _webhost = webhost;
        }

        public async Task<string> SaveFile(IFormFile file)
        {
            var saveimg = Path.Combine(_webhost.WebRootPath, "images", file.FileName);
            //string imgText = Path.GetExtension(file.FileName);
            using (var img = new FileStream(saveimg, FileMode.Create))
            {
                await file.CopyToAsync(img);
            }
            return file.FileName.ToString();
        }
    }
}
