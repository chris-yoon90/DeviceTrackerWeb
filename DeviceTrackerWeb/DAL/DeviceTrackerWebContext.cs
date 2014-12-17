using DeviceTrackerWeb.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DeviceTrackerWeb.DAL
{
    public class DeviceTrackerWebContext : DbContext
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