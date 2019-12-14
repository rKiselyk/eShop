using eShop.Data.Interfaces;
using eShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Controlers {
    public class HomeController:Controller {
        private readonly IAllPhones _phoneRepositiry;

        public HomeController(IAllPhones phoneRepositiry) {
            _phoneRepositiry = phoneRepositiry;
        }

        public ViewResult Index() {
            var homePhones = new HomeViewModel {
                FavouritePhones = _phoneRepositiry.getFavoritePhones
            };

            return View(homePhones);
        }
    }
}
