using EShopSolution.ViewModels.Common;
using EShopSolution.ViewModels.System.Languages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EShopSolution.ApiIntegration
{
    public interface ILanguageApiClient
    {
        Task<ApiResult<List<LanguageViewModel>>> GetAll();            
    }
}
