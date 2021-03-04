using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreate { get; set; }
        public bool? IsFeatured { get; set; }
        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
        public List<Cart> Carts { get; set; }
        public List<ProductTranslations> ProductTranslations { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}
