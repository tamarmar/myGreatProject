using System;
using System.Collections.Generic;
using System.Text;

namespace MyApiProject.Repositories.Entities
{
    public enum EPolicy{Deny,Allow };
    public class Claim
    {
        public int Id { get; set; }

        public int RoleId { get; set; }

        public int PermissionId { get; set; }

        public EPolicy Policy { get; set; }

        public override string ToString()
        {
            return $"Role: Id = {Id}, RoleId={RoleId}, PermissionId={PermissionId},Policy={EPolicy.Allow}";
        }
    }
}
