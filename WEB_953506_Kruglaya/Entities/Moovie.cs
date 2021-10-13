using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_953506_Kruglaya.Entities
{
    public class Moovie
    {
        public int ID { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string Image { get; set; } = "";
        public int CategoryID { get; set; } = 0;
        public Category Category_ { get; set; }
        private int _time;

        public int Time
        {
            get
            {
                return _time;
            }
            set
            {
                if (value > 0)
                {
                    _time = value;
                }
            }
        }
    }
}
