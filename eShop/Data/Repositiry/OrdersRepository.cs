using eShop.Data.Interfaces;
using eShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Data.Repositiry {
    public class OrdersRepository : IAllOrders {
        private readonly AppDBContent _appDBContent;
        private readonly ShopCart _shopCart;

        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart) {
            _appDBContent = appDBContent;
            _shopCart = shopCart;
        }

        public void CreateOrder(Order order) {
            order.OrderTime = DateTime.Now;
            _appDBContent.Order.Add(order);

            var items = _shopCart.ListShopItems;

            foreach (var elem in items) {
                var orderDetail = new OrderDetail() {
                    PhoneId = elem.Phone.Id,
                    OrderId = order.Id,
                    Price = elem.Phone.Price
                };
                _appDBContent.OrderDetail.Add(orderDetail);
            }
            _appDBContent.SaveChanges();
        }
    }
}
