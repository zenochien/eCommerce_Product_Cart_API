﻿using EShopSolution.ViewModels.System.Roles;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Application.System.Roles
{
    public  interface IRoleService
    {
        Task<List<RoleViewModel>> GetAll();
    }
}
