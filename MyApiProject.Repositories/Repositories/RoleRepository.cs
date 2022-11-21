using MyApiProject.Repositories.Entities;
using MyApiProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApiProject.Repositories.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly IContext _context;
        public Role Role;
        public RoleRepository(IContext context)
        {
            _context = context;
        }

        public Role Add(int id, string name, string description)
        {
            var newrole = new Role { Id = id, Name = name, Description = description };
            _context.Roles.Add(newrole);
            return newrole;
        }

        public Role Add(Role role)
        {
            _context.Roles.Add(role);
            return role;
        }

        public void Delete(int id)
        {
            var d= _context.Roles.Find(r => r.Id == id);
            _context.Roles.Remove(d);
        }

        public List<Role> GetAll()
        {
            return _context.Roles;
        }

        public Role GetById(int id)
        {
            return _context.Roles.Find(r => r.Id == id);
        }

        public bool Update(int id, Role role)
        {
            var updatedRole = GetById(id);
            if (updatedRole != null)
            {
                updatedRole.Id = role.Id;
                updatedRole.Name = role.Name;
                updatedRole.Description = role.Description;

                return true;
            }
            else return false;
        }

    }
}
