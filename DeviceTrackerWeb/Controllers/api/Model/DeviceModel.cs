using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using DeviceTrackerWeb.Models;

namespace DeviceTrackerWeb.Controllers.api.Model
{
    public class DeviceModel
    {
        public DeviceModel(Device device)
        {
            this.DeviceId = device.DeviceId;
            this.Model = device.Model;
            this.Made = device.Made;
            this.OS = device.OS;
            this.ScreenSize = device.ScreenSize;
            this.CheckOutTime = device.CheckOutTime;
            this.UserName = device.DTIdentityUser != null
                                ? string.Format(
                                    "{0} {1}",
                                    device.DTIdentityUser.FirstName,
                                    device.DTIdentityUser.LastName)
                                : string.Empty;
            this.CheckedOut = !string.IsNullOrEmpty(this.UserName);

        }

        public string DeviceId { get; set; }
        public string Model { get; set; }
        public string Made { get; set; }
        public string OS { get; set; }
        public double ScreenSize { get; set; }
        public DateTime CheckOutTime { get; set; }
        public string UserName { get; set; }
        public bool CheckedOut { get; set; }
    }
}