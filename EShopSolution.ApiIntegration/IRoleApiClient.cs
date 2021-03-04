﻿using EShopSolution.ViewModels.Common;
using EShopSolution.ViewModels.System.Roles;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.ApiIntegration
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleViewModel>>> GetAll();
    }
}