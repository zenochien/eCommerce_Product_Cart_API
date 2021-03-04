using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_Product_Cart_API.Models
{
    public class ProductDatailViewModel
    {
        public CategoryVm Category { get; set; }

        public ProductVm Product { get; set; }

        public List<ProductVm> RelatedProducts { get; set; }

        public List<ProductImageViewModel> ProductImages { get; set; }

    }
}
