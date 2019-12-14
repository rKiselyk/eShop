using eShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.ViewModels {
    public class HomeViewModel {
        public IEnumerable<Phone> FavouritePhones { get; set; }
    }
}
