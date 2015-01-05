using System.ComponentModel.DataAnnotations;

namespace DeviceTrackerWeb.Models
{
    public class ChangeProfile
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}