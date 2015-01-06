using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

using DeviceTrackerWeb.Models;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DeviceTrackerWeb.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DeviceTrackerWeb.DAL.DeviceTrackerWebContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DeviceTrackerWeb.DAL.DeviceTrackerWebContext";
        }

        protected override void Seed(DeviceTrackerWeb.DAL.DeviceTrackerWebContext context)
        {
            CreateSampleRoles(context);
            CreateSampleAdminUser(context);
            CreateSampleUsers(context);
            CreateSampleDevices(context);
        }

        private void CreateSampleRoles(DeviceTrackerWeb.DAL.DeviceTrackerWebContext db)
        {
            RoleStore<DTIdentityRole> roleStore = new RoleStore<DTIdentityRole>(db);
            RoleManager<DTIdentityRole> roleManager = new RoleManager<DTIdentityRole>(roleStore);

            if (!roleManager.RoleExists("Administrator"))
            {
                DTIdentityRole newRole = new DTIdentityRole("Administrator", "Admin user can add, edit and delete data");
                roleManager.Create(newRole);
            }

            if (!roleManager.RoleExists("Employee"))
            {
                DTIdentityRole newRole = new DTIdentityRole("Employee", "Employee user can only view");
                roleManager.Create(newRole);
            }
        }

        private void CreateSampleAdminUser(DeviceTrackerWeb.DAL.DeviceTrackerWebContext db)
        {
            UserStore<DTIdentityUser> userStore = new UserStore<DTIdentityUser>(db);
            UserManager<DTIdentityUser> userManager = new UserManager<DTIdentityUser>(userStore);

            DTIdentityUser user = new DTIdentityUser();

            user.UserName = "Administrator";
            user.Email = "admin@DTAdmin.com";
            user.FirstName = "Admin";
            user.LastName = "Admin";
            string password = "t3st0rder";

            IdentityResult result = userManager.Create(user, password);

            if (result.Succeeded)
            {
                userManager.AddToRole(user.Id, "Administrator");
            }
        }

        private void CreateSampleUsers(DeviceTrackerWeb.DAL.DeviceTrackerWebContext db)
        {
            UserStore<DTIdentityUser> userStore = new UserStore<DTIdentityUser>(db);
            UserManager<DTIdentityUser> userManager = new UserManager<DTIdentityUser>(userStore);

            int userCount = 50;

            for (int i = 0; i < userCount; i++)
            {
                DTIdentityUser user = new DTIdentityUser();
                user.UserName = string.Format("User_{0}", i);
                user.Email = string.Format("user_{0}@example.com", i);
                user.FirstName = string.Format("User_{0}_FirstName", i);
                user.LastName = string.Format("User_{0}_LastName", i);
                string password = "t3st0rder";

                IdentityResult result = userManager.Create(user, password);

                if (result.Succeeded)
                {
                    userManager.AddToRole(user.Id, "Employee");
                }
            }
        }

        private void CreateSampleDevices(DeviceTrackerWeb.DAL.DeviceTrackerWebContext db)
        {
            UserStore<DTIdentityUser> userStore = new UserStore<DTIdentityUser>(db);
            UserManager<DTIdentityUser> userManager = new UserManager<DTIdentityUser>(userStore);
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
                                           CheckOutTime = createdDate, 
                                           DTIdentityUser = userManager.FindByName("User_1")
                                       },
                                  new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-001", 
                                           Model = "iPhone 5 (Black)",  
                                           Made = "Apple", 
                                           OS = "iOS 7.1", 
                                           ScreenSize = 4, 
                                           CheckOutTime = createdDate,
                                           DTIdentityUser = userManager.FindByName("User_1")
                                       },
                                  new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-027", 
                                           Model = "iPhone 5 S (Gold)",  
                                           Made = "Apple", 
                                           OS = "iOS 8.0", 
                                           ScreenSize = 4, 
                                           CheckOutTime = createdDate,
                                           DTIdentityUser = userManager.FindByName("User_1")
                                       },
                                  new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-035", 
                                           Model = "iPhone 5 S (Green)",  
                                           Made = "Apple", 
                                           OS = "iOS 7.1.2", 
                                           ScreenSize = 4, 
                                           CheckOutTime = createdDate, 
                                           DTIdentityUser = userManager.FindByName("User_2")
                                       },
                                  new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-037", 
                                           Model = "iPhone 6 (Space Gray)",  
                                           Made = "Apple", 
                                           OS = "iOS 8.0.2", 
                                           ScreenSize = 4.7, 
                                           CheckOutTime = createdDate, 
                                           DTIdentityUser = userManager.FindByName("User_3")
                                       },
                                new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-003", 
                                           Model = "iPod Touch 4",  
                                           Made = "Apple", 
                                           OS = "iOS 6.1.6", 
                                           ScreenSize = 3.5, 
                                           CheckOutTime = createdDate, 
                                           DTIdentityUser = userManager.FindByName("User_3")
                                       },
                                 new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-032", 
                                           Model = "iPad Mini (White)",  
                                           Made = "Apple", 
                                           OS = "iOS 8.0", 
                                           ScreenSize = 7.9, 
                                           CheckOutTime = createdDate, 
                                       },
                                 new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-025", 
                                           Model = "iPad Mini (Black)",  
                                           Made = "Apple", 
                                           OS = "iOS 7.1.2", 
                                           ScreenSize = 7.9, 
                                           CheckOutTime = createdDate, 
                                       },
                                 new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-030", 
                                           Model = "Galaxy S5 (Navy)",  
                                           Made = "Samsung", 
                                           OS = "Android 4.4.2", 
                                           ScreenSize = 5.1, 
                                           CheckOutTime = createdDate, 
                                       },

                                 new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-033", 
                                           Model = "Galaxy S5 (White)",  
                                           Made = "Samsung", 
                                           OS = "Android 4.4.2", 
                                           ScreenSize = 5.1, 
                                           CheckOutTime = createdDate, 
                                           DTIdentityUser = userManager.FindByName("User_6")
                                       },
                                       new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-034", 
                                           Model = "Galaxy S5 (White)",  
                                           Made = "Samsung", 
                                           OS = "Android 4.4.2", 
                                           ScreenSize = 5.1, 
                                           CheckOutTime = createdDate, 
                                           DTIdentityUser = userManager.FindByName("User_6")
                                       },
                                       new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-013", 
                                           Model = "Optimus",  
                                           Made = "LG", 
                                           OS = "Android 4.4.4", 
                                           ScreenSize = 7, 
                                           CheckOutTime = createdDate, 
                                           DTIdentityUser = userManager.FindByName("User_7")
                                       },
                                       new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-009", 
                                           Model = "Google Nexus 7",  
                                           Made = "ASUS", 
                                           OS = "Android 4.4.4", 
                                           ScreenSize = 7, 
                                           CheckOutTime = createdDate, 
                                           DTIdentityUser = userManager.FindByName("User_7")
                                       },
                                       new Device
                                       {
                                           DeviceId = "PNI-QA-MTD-031", 
                                           Model = "G-Pad (White)",  
                                           Made = "LG", 
                                           OS = "Android 4.4.4", 
                                           ScreenSize = 8.3, 
                                           CheckOutTime = createdDate, 
                                           DTIdentityUser = userManager.FindByName("User_7")
                                       }
                               };
            devices.ForEach(d => db.Devices.AddOrUpdate(p => p.DeviceId, d));
            db.SaveChanges();
        }
    }
}
