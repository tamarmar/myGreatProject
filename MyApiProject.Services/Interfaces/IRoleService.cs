using MyApiProject.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApiProject.Services.Interfaces
{
    public interface IRoleService
    {
        List<RoleModels> GetList();

        List<RoleModels> Search(string keyword);

        RoleModels GetById(int id);

        RoleModels Add(RoleModels model);

        RoleModels Update(RoleModels model);

        void Delete(int id);
    }
}
