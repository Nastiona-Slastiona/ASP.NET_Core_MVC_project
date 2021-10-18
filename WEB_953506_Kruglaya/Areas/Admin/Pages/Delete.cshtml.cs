using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WEB_953506_Kruglaya.Data;
using WEB_953506_Kruglaya.Entities;

namespace WEB_953506_Kruglaya.Areas.Admin.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly WEB_953506_Kruglaya.Data.ApplicationDbContext _context;

        public DeleteModel(WEB_953506_Kruglaya.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Moovie Moovie { get; set; }

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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Moovie = await _context.Moovies.FindAsync(id);

            if (Moovie != null)
            {
                _context.Moovies.Remove(Moovie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
