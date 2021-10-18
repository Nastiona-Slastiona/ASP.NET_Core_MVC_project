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
    public class IndexModel : PageModel
    {
        private readonly WEB_953506_Kruglaya.Data.ApplicationDbContext _context;

        public IndexModel(WEB_953506_Kruglaya.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Moovie> Moovie { get;set; }

        public async Task OnGetAsync()
        {
            Moovie = await _context.Moovies
                .Include(m => m.Category_).ToListAsync();
        }
    }
}
