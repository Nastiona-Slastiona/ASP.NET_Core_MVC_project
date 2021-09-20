using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WEB_953506_Kruglaya.Components
{
    public class MenuViewComponent: ViewComponent
    {
        private List<Models.MenuItem> _menuItems = new List<Models.MenuItem>
        {
            new Models.MenuItem{ Controller="Home", Action="Index", Text="Lab 3"},
            new Models.MenuItem{ Controller="Product", Action="Index", Text="Каталог"},
            new Models.MenuItem{ IsPage=true, Area="Admin", Page="/Index", Text="Администрирование"}
        };

        public IViewComponentResult Invoke()
        {
            var controller = ViewContext.RouteData.Values["controller"];
            var page = ViewContext.RouteData.Values["page"];
            var area = ViewContext.RouteData.Values["area"];

            foreach(var item in _menuItems)
            {
                var _matchController = controller?.Equals(item.Controller) ?? false;

                var _matchArea = area?.Equals(item.Area) ?? false;

                if(_matchController || _matchArea)
                {
                    item.Active = "active";
                }
            }
            return View(_menuItems);
        }
    }
}
