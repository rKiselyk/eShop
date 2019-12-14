using eShop.Data.Interfaces;
using eShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Data.Repositiry {
    public class PhoneRepositiry : IAllPhones {
        private readonly AppDBContent _appDBContent;

        public PhoneRepositiry(AppDBContent appDBContent) {
            this._appDBContent = appDBContent;
        }

        public IEnumerable<Phone> Phones => _appDBContent.Phone.Include(c => c.Category);
        public IEnumerable<Phone> getFavoritePhones => _appDBContent.Phone.Where(p => p.IsFavourite).Include(c => c.Category);
        public Phone getObjectPhone(int phoneId) => _appDBContent.Phone.FirstOrDefault(p => p.Id == phoneId);
    }
}
