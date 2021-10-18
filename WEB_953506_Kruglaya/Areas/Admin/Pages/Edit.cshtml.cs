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
using Microsoft.EntityFrameworkCore;
using WEB_953506_Kruglaya.Data;
using WEB_953506_Kruglaya.Entities;

namespace WEB_953506_Kruglaya.Areas.Admin.Pages
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;


        public EditModel(WEB_953506_Kruglaya.Data.ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        [BindProperty]
        public Moovie Moovie { get; set; }
        [BindProperty]
        public IFormFile Image { get;set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Moovie = await _context.Moovies
                .Include(m => m.Category_).FirstOrDefaultAsync(m => m.ID == id);

            if (Moovie == null)
            {
                return NotFound();
            }
           ViewData["CategoryID"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if(Image != null)
            {
                var fileName = $"{Moovie.ID}" + Path.GetExtension(Image.FileName);
                Moovie.Image = fileName;
                var path = Path.Combine(_env.WebRootPath, "Images", fileName);
                using (var fs = new FileStream(path, FileMode.Create))
                {
                    await Image.CopyToAsync(fs);
                }
            }

            _context.Attach(Moovie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MoovieExists(Moovie.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MoovieExists(int id)
        {
            return _context.Moovies.Any(e => e.ID == id);
        }
    }
}
