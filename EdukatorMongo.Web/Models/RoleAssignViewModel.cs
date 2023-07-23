using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdukatorMongo.Web.Models
{
    public class RoleAssignViewModel
    {
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public bool RoleExist { get; set; }
    }
}
