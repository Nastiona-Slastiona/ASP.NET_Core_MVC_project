using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_953506_Kruglaya.Entities;
using WEB_953506_Kruglaya.Models;
using WEB_953506_Kruglaya.Extensions;
using WEB_953506_Kruglaya.Data;
using Microsoft.Extensions.Logging;

namespace WEB_953506_Kruglaya.Controllers
{
    public class MoovieController : Controller
    {
        ApplicationDbContext _context;
        int _pageSize;

        public MoovieController(ApplicationDbContext context, ILogger<MoovieController> logger)
        {
            _pageSize = 3;
            _context = context;
        }

        [Route("Moovie/Index_my")]
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
    }
}
