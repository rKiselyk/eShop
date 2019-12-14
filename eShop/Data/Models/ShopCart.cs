using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Data.Models {
    public class ShopCart {
        private readonly AppDBContent _appDBContent;

        public ShopCart(AppDBContent appDBContent) {
            this._appDBContent = appDBContent;
        }

        public string ShopCardId { get; set; }
        public List<ShopCartItem> ListShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services) {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var contex = services.GetService<AppDBContent>();
            string shopCardId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCardId);

            return new ShopCart(contex) { ShopCardId = shopCardId };
        }

        public void AddToCart(Phone phone) {
            _appDBContent.ShopCartItems.Add(new ShopCartItem{
                ShopCartId = ShopCardId,
                Phone = phone,
                Price = phone.Price
            });

            _appDBContent.SaveChanges();
        }

        public List<ShopCartItem> GetShopItems() {
            return _appDBContent.ShopCartItems.Where(c => c.ShopCartId == ShopCardId).Include(s => s.Phone).ToList();
        }
    }
}
