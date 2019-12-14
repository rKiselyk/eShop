using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Data.Models;

namespace eShop.Data.Interfaces {
    public interface IAllPhones {
        IEnumerable<Phone> Phones { get;  }
        IEnumerable<Phone> getFavoritePhones { get; }
        Phone getObjectPhone(int carId);
    }
}
