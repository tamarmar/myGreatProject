using MyApiProject.Repositories.Entities;
using MyApiProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApiProject.Repositories.Repositories
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly IContext _context;

        public PermissionRepository(IContext context)
        {
            _context = context;
        }

        public Permission Add(int id, string name, string description)
        {
            Permission permission = new Permission { Id = id, Name = name, Description = description };
            _context.Permissions.Add(permission);
            return permission;
        }

        public void Delete(int id)
        {
            Permission permission = GetById(id);
            _context.Permissions.Remove(permission);
        }

        public List<Permission> GetAll()
        {
            return _context.Permissions;
        }

        public Permission GetById(int id)
        {
            return _context.Permissions.Find(x => x.Id == id);
        }

        public Permission Update(Permission permission)
        {
            var p = GetById(permission.Id);
            permission.Name = p.Name;
            permission.Description = p.Description;
            return permission;
        }
    }
}
