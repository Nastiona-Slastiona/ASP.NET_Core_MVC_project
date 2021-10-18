using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEB_953506_Kruglaya.Data;
using WEB_953506_Kruglaya.Entities;

namespace WEB_953506_Kruglaya.Areas.Admin.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public CreateModel(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _environment = env;
        }

        public IActionResult OnGet()
        {
        ViewData["CategoryID"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            return Page();
        }

        [BindProperty]
        public Moovie Moovie { get; set; }
        [BindProperty]
        public IFormFile Image { get; set; }    


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Moovies.Add(Moovie);
            await _context.SaveChangesAsync();

            if(Image != null)
            {
                var fileName=$"{Moovie.ID}"
                    + Path.GetExtension(Image.FileName);
                Moovie.Image = fileName;
                var path = Path.Combine(_environment.WebRootPath, "Images", fileName);
                using (var fs = new FileStream(path, FileMode.Create))
                {
                    await Image.CopyToAsync(fs);
                }
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
