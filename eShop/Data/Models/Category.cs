using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Data.Models {
    public class Category {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Descriotion { get;set;}
        public List<Phone> Cars { get; set; } 
    }
}
