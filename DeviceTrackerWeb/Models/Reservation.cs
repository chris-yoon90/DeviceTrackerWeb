using System;
using System.ComponentModel.DataAnnotations;

namespace DeviceTrackerWeb.Models
{
    public class Reservation
    {
        public int ID { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd H:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime ReservationCheckOutTime { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd H:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime ReservationCheckInTime { get; set; }

        public virtual DTIdentityUser DTIdentityUser { get; set; }

        public virtual Device Device { get; set; }
    }
}