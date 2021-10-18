using System;
using System.Collections.Generic;
using System.Linq;
using WEB_953506_Kruglaya.Entities;

namespace WEB_953506_Kruglaya.Models
{
    [Serializable]
    public class Cart
    {
        public Dictionary<int, CartItem> Items { get; set; } 

       

        public Cart()
        {
            Items = new Dictionary<int, CartItem>();
        }

        public int Count
        {
            get
            {
                return Items.Sum(item => item.Value.Quantity);
            }
        }

        public int MoovieTime
        {
            get
            {
                return Items.Sum(item => item.Value.Quantity * item.Value.Moovie.Time);
            }
        }
        public virtual void AddtoCart(Moovie moovie)
        {
            if (Items.ContainsKey(moovie.ID))
            {
                Items[moovie.ID].Quantity++;
               

            }
            else
            {
                Items.Add(moovie.ID, new CartItem
                {
                    Moovie = moovie,
                    Quantity = 1
                });
            }

        }

        public virtual void RemovefromCart(int id)
        {
            Items.Remove(id);
        }

        public virtual void ClearAll()
        {
            Items.Clear();
        }

    }
    [Serializable]
    public class CartItem
    {
        public Moovie Moovie { get; set; }
        public int Quantity { get; set; }
    }
}
