using eShop.Data.Interfaces;
using eShop.Data.Models;
using eShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Controlers {
    public class ShopCartController:Controller {
        private readonly IAllPhones _phoneRepositiry;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllPhones phoneRepositiry, ShopCart shopCart) {
            _phoneRepositiry = phoneRepositiry;
            _shopCart = shopCart;
        }

        public ViewResult Index() {
            var items = _shopCart.GetShopItems();
            _shopCart.ListShopItems = items;

            var obj = new ShopCartViewModel {
                ShopCart = _shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult AddToCart(int id) {
            var item = _phoneRepositiry.Phones.FirstOrDefault(i => i.Id == id);

            if (item != null) {
                _shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }
    }
}
