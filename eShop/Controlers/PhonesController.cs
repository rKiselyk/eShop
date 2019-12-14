using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using eShop.Data.Interfaces;
using eShop.ViewModels;
using eShop.Data.Models;

namespace eShop.Controlers {
    public class PhonesController : Controller {
        private readonly IAllPhones _allPhones;
        private readonly IPhonesCategory _allCategories;

        public PhonesController(IAllPhones iAllPhoes, IPhonesCategory iPhonesCategory) {
            _allPhones = iAllPhoes;
            _allCategories = iPhonesCategory;
        }

        [Route("Phones/getListPhones")]
        [Route("Phones/getListPhones/{category}")]
        public ViewResult getListPhones(string category) {
            string _category = category;
            IEnumerable<Phone> phones = null;
            string currentCategory = "";

            if (string.IsNullOrEmpty(category)) {
                phones = _allPhones.Phones.OrderBy(i => i.Id);
            } else {
                if (string.Equals("Iphone", category, StringComparison.OrdinalIgnoreCase)) {
                    phones = _allPhones.Phones.Where(i => i.Category.CategoryName.Equals("Iphone")).OrderBy(i => i.Id);
                }
                if (string.Equals("Android", category, StringComparison.OrdinalIgnoreCase)) {
                    phones = _allPhones.Phones.Where(i => i.Category.CategoryName.Equals("Android")).OrderBy(i => i.Id);
                }

                currentCategory = _category;
            }

            var phoneObj = new PhonesListViewModel {
                AllPhones = phones,
                CurrentCategory = currentCategory
            };

            ViewBag.Title = "Page with Phones";

            return View(phoneObj);
        }
    }
}
