﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iShop.Web.Server.Core.Resources
{
    public class CartResource
    {
        public ProductResource Product { get; set; }
        public ShoppingCartResource ShoppingCart { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
