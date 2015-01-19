using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;

using DeviceTrackerWeb.Controllers.api.Model;
using DeviceTrackerWeb.DAL;
using DeviceTrackerWeb.Models;

namespace DeviceTrackerWeb.Controllers.api
{
    [RoutePrefix("api/v1/devices")]
    public class DevicesController : ApiController
    {
        private DeviceTrackerWebContext db = new DeviceTrackerWebContext();

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetDevices()
        {
            var devices = new DeviceModelList(db.Devices);

            return this.Ok(devices);
        }

        // GET: api/v1/Devices/5
        [HttpGet]
        [Route("{id}")]
        [ResponseType(typeof(DeviceModel))]
        public IHttpActionResult GetDevice(string id)
        {
            Device device = db.Devices.FirstOrDefault(d => d.DeviceId == id);
            if (device == null)
            {
                return NotFound();
            }

            var model = new DeviceModel(device);

            return Ok(model);
        }

        // PUT: api/Devices/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutDevice(int id, Device device)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != device.ID)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(device).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!DeviceExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/Devices
        //[ResponseType(typeof(Device))]
        //public IHttpActionResult PostDevice(Device device)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Devices.Add(device);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = device.ID }, device);
        //}

        //// DELETE: api/Devices/5
        //[ResponseType(typeof(Device))]
        //public IHttpActionResult DeleteDevice(int id)
        //{
        //    Device device = db.Devices.Find(id);
        //    if (device == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Devices.Remove(device);
        //    db.SaveChanges();

        //    return Ok(device);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool DeviceExists(int id)
        //{
        //    return db.Devices.Count(e => e.ID == id) > 0;
        //}
    }
}