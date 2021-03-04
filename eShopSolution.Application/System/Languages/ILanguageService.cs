using EShopSolution.ViewModels.Common;
using EShopSolution.ViewModels.System.Languages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Application.System
{
    public interface ILanguageService
    {
        Task<ApiResult<List<LanguageViewModel>>> GetAll();
    }
}
