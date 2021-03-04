using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_Product_Cart_API.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryVm Category { get; set; }

        public PagedResult<ProductVm> Products { get; set; }

    }
}
