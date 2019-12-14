using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using eShop.Data.Interfaces;
using eShop.ViewModels;

namespace eShop.Controlers {
    public class PhonesController : Controller {
        private readonly IAllPhones _allPhones;
        private readonly IPhonesCategory _allCategories;

        public PhonesController(IAllPhones iAllPhoes, IPhonesCategory iPhonesCategory) {
            _allPhones = iAllPhoes;
            _allCategories = iPhonesCategory;
        }

        public ViewResult getListPhones() {
            ViewBag.Title = "Page with Phones";
            PhonesListViewModel obj = new PhonesListViewModel();
            obj.AllPhones = _allPhones.Phones;
            obj.CurrentCategory = "Phone";

            return View(obj);
        }
    }
}
