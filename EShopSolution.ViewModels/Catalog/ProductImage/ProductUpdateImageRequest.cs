using Microsoft.AspNetCore.Http;

namespace EShopSolution.ViewModels.Catalog.ProductImage
{
    public class ProductUpdateImageRequest
    {
        public int Id { get; set; }

        public string Caption { get; set; }

        public bool IsDefault { get; set; }

        public int SortOrder { get; set; }

        public IFormFile ImageFile { get; set; }
    }
}
