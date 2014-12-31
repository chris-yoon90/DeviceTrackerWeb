using Microsoft.AspNet.Identity.EntityFramework;

namespace DeviceTrackerWeb.Models
{
    public class DTIdentityUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}