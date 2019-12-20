using Microsoft.AspNetCore.Identity;

namespace OasisComputerSystems.API.Models
{
    public class StaffProfileRole : IdentityUserRole<int>
    {
        public StaffProfile StaffProfile { get; set; }
        public Role Role { get; set; }
    }
}