using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GalleryApp.Pages
{
    public class PhotosModel : PageModel
    {
        public List<string> FileNames { get; set; }
        public void OnGet()
        {
            FileNames = new List<string>();

            var limit = 10;
            for (int i = 1; i <= limit; i++)
            {
                FileNames.Add(i + ".jpg");
            }
        }
    }
}