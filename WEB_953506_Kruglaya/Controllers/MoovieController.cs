using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_953506_Kruglaya.Entities;
using WEB_953506_Kruglaya.Models;
using WEB_953506_Kruglaya.Extensions;
using WEB_953506_Kruglaya.Data;

namespace WEB_953506_Kruglaya.Controllers
{
    public class MoovieController : Controller
    {
        ApplicationDbContext _context;
        /*public List<Moovie> _mooviesList;
        public List<Category> _categoriesList;*/
        int _pageSize;

        public MoovieController(ApplicationDbContext context)
        {
            _pageSize = 3;
            _context = context;
            /*ListsInit();*/
        }

        [Route("Moovie/%2FIndex_my")]
        [Route("page_{page}")]
        public IActionResult Index_my(int? categories, int page=1)
        {
            var mooviesFilt = _context.Moovies
                .Where(m => !categories.HasValue || m.CategoryID == categories.Value);
            ViewData["Text"] = "MoovieController";
            ViewData["Categories"] = _context.Categories;
            ViewData["CurrentCategory"] = categories ?? 0;
            var model = ListViewModel<Moovie>.GetModel(mooviesFilt, page, _pageSize);
            if (Request.IsAjaxRequest())
                return PartialView("_listpartial", model);
            else
                return View(model);
        }

       /* public void ListsInit()
        {
            _categoriesList = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Inspiration", Moovies= _mooviesList},
                new Category{CategoryId = 2, CategoryName = "Comedy", Moovies= _mooviesList},
                new Category{CategoryId = 3, CategoryName = "Music", Moovies= _mooviesList},
                new Category{CategoryId = 4, CategoryName = "Horror", Moovies= _mooviesList}
            };
            _mooviesList = new List<Moovie> {
                new Moovie{ID = 1, Name = "В погоне за счастьем", Description = "Moovie about men's life.", CategoryID = 1, Time = 90, Category_=_categoriesList[0], Image = "First.jpg" },
                new Moovie{ID = 1, Name = "Всегда говори Да", Description = "Moovie about men's life.", CategoryID = 2, Time = 120, Category_=_categoriesList[1], Image = "Second.jpg" },
                new Moovie{ID = 1, Name = "La-La-Land", Description = "Moovie about men's life.", CategoryID = 3, Time = 115, Category_=_categoriesList[2], Image = "3.jpg" },
                new Moovie{ID = 1, Name = "Оно", Description = "Moovie about men's life.", CategoryID = 4, Time = 113, Category_=_categoriesList[3], Image = "4.jpg" },
                new Moovie{ID = 1, Name = "Отпетые мошенницы", Description = "Moovie about men's life.", CategoryID = 2, Time = 120, Category_=_categoriesList[2], Image = "5.jpg" }
            };
        }*/

    }
}
