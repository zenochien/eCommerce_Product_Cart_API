using EShopSolution.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShopSolution.ViewModels.Catalog.Cart
{
    public class CheckoutViewModel
    {
        public List<CartItemViewModel> CartItems { get; set; }

        public CheckOutRequest CheckoutModel { get; set; }
    }
}
