using System.Data.Entity;

using DeviceTrackerWeb.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DeviceTrackerWeb.DAL
{
    public class DeviceTrackerWebContext : IdentityDbContext<DTIdentityUser>
    {
        public DeviceTrackerWebContext()
            : base("DeviceTrackerWebContext")
        {
        }
        
        public DbSet<Device> Devices { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}