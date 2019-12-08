using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Data.Interfaces;
using eShop.Data.Models;

namespace eShop.Data.Mocks {
    public class MockCategory : IPhonesCategory {
        public IEnumerable<Category> AllCategories {
            get {
                return new List<Category> {
                    new Category{ CategoryName =  "Iphone", Descriotion = "Smartphone with IOS" },
                    new Category{ CategoryName = "Android", Descriotion = "Smartphone with Android OS" }
                };
            }
        }
    }
}
