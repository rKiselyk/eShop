using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Data.Models {
    public class Phone {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int Image { get; set; }
        public ushort Price { get; set; }
        public bool IsFavourite { get; set; }
        public int Available { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
