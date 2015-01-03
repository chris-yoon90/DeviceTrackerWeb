using System.ComponentModel.DataAnnotations;

namespace DeviceTrackerWeb.Models
{
    public class ChangeProfile
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}