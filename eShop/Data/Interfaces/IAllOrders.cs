﻿using eShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Data.Interfaces {
    public interface IAllOrders {
        void CreateOrder(Order order);
    }
}
