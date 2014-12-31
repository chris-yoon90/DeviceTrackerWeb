using System;
using System.Collections.Generic;

using DeviceTrackerWeb.Models;

namespace DeviceTrackerWeb.DAL
{
    [Obsolete]
    public class DeviceTrackerWebInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DeviceTrackerWebContext>
    {
        protected override void Seed(DeviceTrackerWebContext context)
        {
            var createdDate = DateTime.Now;
            var devices = new List<Device>
                               {
                                   new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-006", 
                                           Model = "iPhone 5 (Black)",  
                                           Made = "Apple", 
                                           OS = "8.0", 
                                           ScreenSize = 4, 
                                           User = "",
                                           CheckOutTime = createdDate, 
                                       },
                                  new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-001", 
                                           Model = "iPhone 5 (Black)",  
                                           Made = "Apple", 
                                           OS = "7.1", 
                                           ScreenSize = 4, 
                                           User = "",
                                           CheckOutTime = createdDate, 
                                       },
                                  new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-027", 
                                           Model = "iPhone 5 S (Gold)",  
                                           Made = "Apple", 
                                           OS = "8.0", 
                                           ScreenSize = 4, 
                                           User = "",
                                           CheckOutTime = createdDate, 
                                       },
                                  new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-035", 
                                           Model = "iPhone 5 S (Green)",  
                                           Made = "Apple", 
                                           OS = "7.1.2", 
                                           ScreenSize = 4, 
                                           User = "",
                                           CheckOutTime = createdDate, 
                                       },
                                  new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-037", 
                                           Model = "iPhone 6 (Space Gray)",  
                                           Made = "Apple", 
                                           OS = "8.0.2", 
                                           ScreenSize = 4.7, 
                                           User = "",
                                           CheckOutTime = createdDate, 
                                       },
                                new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-003", 
                                           Model = "iPod Touch 4",  
                                           Made = "Apple", 
                                           OS = "6.1.6", 
                                           ScreenSize = 3.5, 
                                           User = "",
                                           CheckOutTime = createdDate, 
                                       },
                                 new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-032", 
                                           Model = "iPad Mini (White)",  
                                           Made = "Apple", 
                                           OS = "8.0", 
                                           ScreenSize = 7.9, 
                                           User = "",
                                           CheckOutTime = createdDate, 
                                       },
                                 new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-025", 
                                           Model = "iPad Mini (Black)",  
                                           Made = "Apple", 
                                           OS = "7.1.2", 
                                           ScreenSize = 7.9, 
                                           User = "",
                                           CheckOutTime = createdDate, 
                                       },
                                 new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-030", 
                                           Model = "Galaxy S5 (Navy)",  
                                           Made = "Samsung", 
                                           OS = "4.4.2", 
                                           ScreenSize = 5.1, 
                                           User = "",
                                           CheckOutTime = createdDate, 
                                       },

                                 new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-033", 
                                           Model = "Galaxy S5 (While)",  
                                           Made = "Samsung", 
                                           OS = "4.4.2", 
                                           ScreenSize = 5.1, 
                                           User = "",
                                           CheckOutTime = createdDate, 
                                       },
                                       new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-034", 
                                           Model = "Galaxy S5 (While)",  
                                           Made = "Samsung", 
                                           OS = "4.4.2", 
                                           ScreenSize = 5.1, 
                                           User = "",
                                           CheckOutTime = createdDate, 
                                       },
                                       new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-013", 
                                           Model = "Optimus",  
                                           Made = "LG", 
                                           OS = "4.4.4", 
                                           ScreenSize = 7, 
                                           User = "",
                                           CheckOutTime = createdDate, 
                                       },
                                       new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-009", 
                                           Model = "Google Nexus 7",  
                                           Made = "ASUS", 
                                           OS = "4.4.4", 
                                           ScreenSize = 7, 
                                           User = "",
                                           CheckOutTime = createdDate, 
                                       },
                                       new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-031", 
                                           Model = "G-Pad (White)",  
                                           Made = "LG", 
                                           OS = "4.4.4", 
                                           ScreenSize = 8.3, 
                                           User = "",
                                           CheckOutTime = createdDate, 
                                       }
                               };
            devices.ForEach(d => context.Devices.Add(d));
            context.SaveChanges();
        }
    }
}