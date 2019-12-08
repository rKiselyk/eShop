using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Data.Models;

namespace eShop.Data.Interfaces {
    interface IAllPhones {
        IEnumerable<Phone> Phones { get; set; }
        IEnumerable<Phone> getFavoritePhones { get; set; }
        Phone getObjectPhone(int carId);
    }
}
