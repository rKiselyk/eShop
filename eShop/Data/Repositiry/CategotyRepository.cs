using eShop.Data.Interfaces;
using eShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Data.Repositiry {
    public class CategotyRepository : IPhonesCategory {
        private readonly AppDBContent _appDBContent;

        public CategotyRepository(AppDBContent appDBContent) {
            this._appDBContent = appDBContent;
        }

        public IEnumerable<Category> AllCategories => _appDBContent.Category;
    }
}
