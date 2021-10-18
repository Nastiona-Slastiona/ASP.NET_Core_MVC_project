using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB_953506_Kruglaya.Extensions;
using WEB_953506_Kruglaya.Models;

namespace WEB_953506_Kruglaya.Components
{
    public class CartViewComponent: ViewComponent
    {
        private Cart _cart;
        public CartViewComponent(Cart cart)
        {
            _cart = cart;
        }
        public IViewComponentResult Invoke()
        {
            
            return View(_cart);
        }
    }
}
