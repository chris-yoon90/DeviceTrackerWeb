using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using DeviceTrackerWeb.Models;

namespace DeviceTrackerWeb.Controllers.api.Model
{
    public class DeviceModelList
    {
        public DeviceModelList(DbSet<Device> devices)
        {
            this.Devices = devices.ToList().Select(d => new DeviceModel(d));
        }

        public IEnumerable<DeviceModel> Devices { get; set; }
    }

}