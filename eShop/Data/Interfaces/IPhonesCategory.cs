﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Data.Models;

namespace eShop.Data.Interfaces {
    public interface IPhonesCategory {
        IEnumerable<Category> AllCategories { get;  }
    }
}
