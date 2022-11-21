using MyApiProject.Mock;
using MyApiProject.Repositories.Entities;
using MyApiProject.Repositories.Interfaces;
using MyApiProject.Repositories.Repositories;
using System;

namespace MyApiProject.ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            var role1 = new Role { Id = 1, Name = "admin", Description = "admin" };
            var role2 = new Role { Id = 2, Name = "user", Description = "user" };

            var permission1 = new Permission { Id = 10, Name = "VIEW_ALL_PRODUCTS" };
            var permission2 = new Permission { Id = 20, Name = "VIEW_ALL_ORDERS" };

            var claim1 = new Claim { Id = 1, RoleId = 1, PermissionId = 10, Policy = EPolicy.Allow };
            var claim2 = new Claim { Id = 2, RoleId = 1, PermissionId = 20, Policy = EPolicy.Allow };
            var claim3 = new Claim { Id = 3, RoleId = 2, PermissionId = 10, Policy = EPolicy.Allow };
            var claim4 = new Claim { Id = 4, RoleId = 2, PermissionId = 20, Policy = EPolicy.Deny };


            var m = new MockContext();
            Console.WriteLine(role1.Name);
            Console.WriteLine(claim3.Policy);

            var roleRepository = new RoleRepository(m);
            




            Console.WriteLine(roleRepository.GetById(2));
            roleRepository.GetAll().ForEach(r => Console.WriteLine(r.ToString()));
        }
    }
}
