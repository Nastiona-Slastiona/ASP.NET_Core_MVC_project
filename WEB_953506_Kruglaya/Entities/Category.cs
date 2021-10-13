using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_953506_Kruglaya.Entities
{
    public class Category
    {
        public int CategoryId { get; set; } = 0;
        public string CategoryName { get; set; } = "";
        public List<Moovie> Moovies { get; set; }
    }
}
