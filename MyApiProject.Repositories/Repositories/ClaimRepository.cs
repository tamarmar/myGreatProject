using MyApiProject.Repositories.Entities;
using MyApiProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApiProject.Repositories.Repositories
{
    public class ClaimRepository : IClaimRepository
    {
        private readonly IContext _context;

        public ClaimRepository(IContext context)
        {
            _context = context;
        }

        public Claim Add(int id, int roleid, int permissionid, EPolicy policy)
        {
            Claim claim = new Claim { Id = id, RoleId = roleid, PermissionId = permissionid, Policy = policy };
            _context.Claims.Add(claim);
            return claim;
        }

        public void Delete(int id)
        {
            Claim claim = GetById(id);
            _context.Claims.Remove(claim);
        }

        public List<Claim> GetAll()
        {
            return _context.Claims;
        }

        public Claim GetById(int id)
        {
            return _context.Claims.Find(p => p.Id == id);
        }

        public Claim Update(Claim claim)
        {
            var c = GetById(claim.Id);
            claim.RoleId = c.RoleId;
            claim.PermissionId = c.PermissionId;
            return claim;
        }
    }
}
