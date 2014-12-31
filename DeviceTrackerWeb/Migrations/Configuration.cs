namespace DeviceTrackerWeb.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    using DeviceTrackerWeb.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<DeviceTrackerWeb.DAL.DeviceTrackerWebContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DeviceTrackerWeb.DAL.DeviceTrackerWebContext";
        }

        protected override void Seed(DeviceTrackerWeb.DAL.DeviceTrackerWebContext context)
        {
            var createdDate = DateTime.Now;
            var devices = new List<Device>
                               {
                                   new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-006", 
                                           Model = "iPhone 5 (Black)",  
                                           Made = "Apple", 
                                           OS = "iOS 8.0", 
                                           ScreenSize = 4, 
                                           User = "Tom",
                                           CheckOutTime = createdDate, 
                                       },
                                  new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-001", 
                                           Model = "iPhone 5 (Black)",  
                                           Made = "Apple", 
                                           OS = "iOS 7.1", 
                                           ScreenSize = 4, 
                                           User = "Eddie",
                                           CheckOutTime = createdDate, 
                                       },
                                  new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-027", 
                                           Model = "iPhone 5 S (Gold)",  
                                           Made = "Apple", 
                                           OS = "iOS 8.0", 
                                           ScreenSize = 4, 
                                           User = "",
                                           CheckOutTime = createdDate, 
                                       },
                                  new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-035", 
                                           Model = "iPhone 5 S (Green)",  
                                           Made = "Apple", 
                                           OS = "iOS 7.1.2", 
                                           ScreenSize = 4, 
                                           User = "",
                                           CheckOutTime = createdDate, 
                                       },
                                  new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-037", 
                                           Model = "iPhone 6 (Space Gray)",  
                                           Made = "Apple", 
                                           OS = "iOS 8.0.2", 
                                           ScreenSize = 4.7, 
                                           User = "Chris",
                                           CheckOutTime = createdDate, 
                                       },
                                new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-003", 
                                           Model = "iPod Touch 4",  
                                           Made = "Apple", 
                                           OS = "iOS 6.1.6", 
                                           ScreenSize = 3.5, 
                                           User = "Victor",
                                           CheckOutTime = createdDate, 
                                       },
                                 new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-032", 
                                           Model = "iPad Mini (White)",  
                                           Made = "Apple", 
                                           OS = "iOS 8.0", 
                                           ScreenSize = 7.9, 
                                           User = "",
                                           CheckOutTime = createdDate, 
                                       },
                                 new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-025", 
                                           Model = "iPad Mini (Black)",  
                                           Made = "Apple", 
                                           OS = "iOS 7.1.2", 
                                           ScreenSize = 7.9, 
                                           User = "Aaron",
                                           CheckOutTime = createdDate, 
                                       },
                                 new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-030", 
                                           Model = "Galaxy S5 (Navy)",  
                                           Made = "Samsung", 
                                           OS = "Android 4.4.2", 
                                           ScreenSize = 5.1, 
                                           User = "",
                                           CheckOutTime = createdDate, 
                                       },

                                 new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-033", 
                                           Model = "Galaxy S5 (White)",  
                                           Made = "Samsung", 
                                           OS = "Android 4.4.2", 
                                           ScreenSize = 5.1, 
                                           User = "",
                                           CheckOutTime = createdDate, 
                                       },
                                       new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-034", 
                                           Model = "Galaxy S5 (White)",  
                                           Made = "Samsung", 
                                           OS = "Android 4.4.2", 
                                           ScreenSize = 5.1, 
                                           User = "",
                                           CheckOutTime = createdDate, 
                                       },
                                       new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-013", 
                                           Model = "Optimus",  
                                           Made = "LG", 
                                           OS = "Android 4.4.4", 
                                           ScreenSize = 7, 
                                           User = "Paola",
                                           CheckOutTime = createdDate, 
                                       },
                                       new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-009", 
                                           Model = "Google Nexus 7",  
                                           Made = "ASUS", 
                                           OS = "Android 4.4.4", 
                                           ScreenSize = 7, 
                                           User = "Beau",
                                           CheckOutTime = createdDate, 
                                       },
                                       new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-031", 
                                           Model = "G-Pad (White)",  
                                           Made = "LG", 
                                           OS = "Android 4.4.4", 
                                           ScreenSize = 8.3, 
                                           User = "",
                                           CheckOutTime = createdDate, 
                                       }
                               };
            devices.ForEach(d => context.Devices.AddOrUpdate(p => p.DeviceId, d));
            context.SaveChanges();
        }
    }
}