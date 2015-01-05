using System;

using System.ComponentModel.DataAnnotations;

namespace DeviceTrackerWeb.Models
{
    public class Device
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string DeviceId { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        [Required]
        [StringLength(50)]
        public string Made { get; set; }

        [Required]
        [StringLength(50)]
        public string OS { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "The screen size must be greater than 0")]
        public double ScreenSize { get; set; }

        [StringLength(50)]
        public string User { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd H:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime CheckOutTime { get; set; }

        //public virtual int DTIdentityUserID { get; set; }
        //public virtual DTIdentityUser DTIdentityUser { get; set; }
    }
}