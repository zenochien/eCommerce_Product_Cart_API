using EShopSolution.ViewModels.Common;
using System.Collections.Generic;

namespace EShopSolution.ViewModels.Catalog.Products.Manage
{
    public class GetProductPaginRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryId { get; set; }

    }
}
