using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using Microsoft.AspNet.Identity.EntityFramework;

namespace DeviceTrackerWeb.Models
{


    public class DTIdentityUser : IdentityUser
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        //public virtual ICollection<Device> Devices { get; set; }
    }
}