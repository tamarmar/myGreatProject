using MyApiProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApiProject.Repositories.Interfaces
{
    public interface IClaimRepository
    {
        List<Claim> GetAll();

        Claim GetById(int id);

        Claim Add(int id, int roleid, int permissionid,EPolicy policy);

        Claim Update(Claim claim);

        void Delete(int id);
    }
}
