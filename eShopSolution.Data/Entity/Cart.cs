﻿using eShopSolution.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data
{
    public class Cart
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Guid UserId { get; set; }
        public Product Products { get; set; }
        public DateTime DateCreated { get; set; }
        public AppUser AppUser { get; set; }
    }
}
