using MyApiProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApiProject.Repositories.Interfaces
{
    public interface IRoleRepository
    {
        List<Role> GetAll();

        Role GetById(int id);

        Role Add(int id, string name, string description);

        Role Add(Role role);

        bool Update(int id, Role role);

        void Delete(int id);

    

    }
}
