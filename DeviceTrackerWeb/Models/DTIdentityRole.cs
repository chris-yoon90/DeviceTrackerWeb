using Microsoft.AspNet.Identity.EntityFramework;

namespace DeviceTrackerWeb.Models
{
    public class DTIdentityRole : IdentityRole
    {
        public string Description { get; set; }

        public DTIdentityRole()
        {
            
        }

        public DTIdentityRole(string roleName, string description)
            : base(roleName)
        {
            this.Description = description;
        }

    }
}