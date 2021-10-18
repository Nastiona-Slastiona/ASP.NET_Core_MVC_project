using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_953506_Kruglaya.Controllers
{
    public class ListDemo
    {
        public int ListItemValue { get; set; }
        public string ListItemText { get; set; }
    }

    public class HomeController : Controller
    {

       
        public IActionResult Index()
        {
            ViewData["Lst"] = new SelectList(_listDemo, "ListItemValue", "ListItemText");
            return View();
        }

        private List<ListDemo> _listDemo;

        public HomeController()
        {
            _listDemo = new List<ListDemo>
            {
                new ListDemo{ ListItemValue=1, ListItemText="Пункт 1"},
                new ListDemo{ ListItemValue=2, ListItemText="Пункт 2"},
                new ListDemo{ ListItemValue=3, ListItemText="Пункт 3"}
            };
        }
      
    }
}
