using EShopSolution.ViewModels.Catalog;
using EShopSolution.ViewModels.Catalog.Products;
using EShopSolution.ViewModels.Catalog.Products.Manage;
using EShopSolution.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EShopSolution.ApiIntegration
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductViewModel>> GetPagings(GetManageProductPagingRequest request);

        Task<bool> CreateProduct(ProductCreateRequest request);

        Task<bool> UpdateProduct(ProductUpdateRequest request);

        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);

        Task<ProductViewModel> GetById(int id, string languageId);

        Task<List<ProductViewModel>> GetFeaturedProducts(string languageId, int take);

        Task<List<ProductViewModel>> GetLatestProducts(string languageId, int take);

        Task<bool> DeleteProduct(int id);
    }
}