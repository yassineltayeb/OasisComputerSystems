using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace OasisComputerSystems.API.Models
{
    public class Role : IdentityRole<int>
    {
        public ICollection<StaffProfileRole> StaffProfileRoles { get; set; }
    }
}