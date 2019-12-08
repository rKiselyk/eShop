using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Data.Models;

namespace eShop.ViewModels {
    public class PhonesListViewModel {
        public IEnumerable<Phone> AllPhones { get; set; }
        public string CurrentCategory { get; set; }
    }
}
