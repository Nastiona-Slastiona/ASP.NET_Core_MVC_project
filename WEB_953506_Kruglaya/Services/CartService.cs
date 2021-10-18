using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using WEB_953506_Kruglaya.Entities;
using WEB_953506_Kruglaya.Extensions;
using WEB_953506_Kruglaya.Models;

namespace WEB_953506_Kruglaya.Services
{
    public class CartService: Cart
    {
        private string sessionKey = "cart";
        [System.Text.Json.Serialization.JsonIgnore]
        ISession Session { get; set; }  

        public static Cart GetCart(IServiceProvider sp)
        {
            var session = sp.GetRequiredService<IHttpContextAccessor>()
                .HttpContext.Session;
            var cart = session?.Get<CartService>("cart")?? new CartService();
            cart.Session = session;
            return cart;
        }

        public override void AddtoCart(Moovie moovie)
        {
            base.AddtoCart(moovie);
            Session?.Set<CartService>(sessionKey, this);
        }
        public override void RemovefromCart(int id)
        {
            base.RemovefromCart(id);
            Session?.Set<CartService>(sessionKey, this);
        }
        public override void ClearAll()
        {
            base.ClearAll();
            Session?.Set<CartService>(sessionKey, this);
        }
    }
}
