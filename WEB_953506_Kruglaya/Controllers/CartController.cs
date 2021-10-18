using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB_953506_Kruglaya.Data;
using WEB_953506_Kruglaya.Extensions;
using WEB_953506_Kruglaya.Models;

namespace WEB_953506_Kruglaya.Controllers
{
    public class CartController : Controller
    {
        private ApplicationDbContext _context;
        private Cart _cart;
        private string cartKey = "cart";

        public CartController(ApplicationDbContext context, Cart cart)
        {
            _context = context;
            _cart = cart;
        }

        public IActionResult Index()
        {
            return View(_cart.Items.Values);
        }

        [Microsoft.AspNetCore.Authorization.Authorize]
        public IActionResult Add(int id, string returnUrl)
        {
            


            var item = _context.Moovies.Find(id);
            if (item != null)
            {
                _cart.AddtoCart(item);
               
            }
            return Redirect(returnUrl);
        }
        public IActionResult Delete(int id)
        {
            _cart.RemovefromCart(id);
            return RedirectToAction("Index");
        }

       
    }
}
