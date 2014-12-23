using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DeviceTrackerWeb.DAL;
using DeviceTrackerWeb.Models;

namespace DeviceTrackerWeb.Controllers
{
    public class DevicesController : Controller
    {
        private DeviceTrackerWebContext db = new DeviceTrackerWebContext();

        // GET: Devices
        public ActionResult Index(string searchString, string sortOrder)
        {
            ViewBag.DeviceIdSort = string.IsNullOrEmpty(sortOrder) ? "deviceId_desc" : string.Empty;
            ViewBag.DeviceModelSort = sortOrder == "Model" ? "model_desc" : "Model";
            ViewBag.DeviceMadeSort = sortOrder == "Made" ? "made_desc" : "Made";
            ViewBag.DeviceOSSort = sortOrder == "OS" ? "os_desc" : "OS";
            ViewBag.DeviceScreenSizeSort = sortOrder == "ScreenSize" ? "screen_size_desc" : "ScreenSize";
            ViewBag.DeviceUserSort = sortOrder == "User" ? "user_desc" : "User";
            ViewBag.DeviceCheckoutDateSort = sortOrder == "Checkout" ? "checkout_desc" : "Checkout";

            var devices = from d in db.Devices select d;
            if (!string.IsNullOrEmpty(searchString))
            {
                devices = devices.Where(d => 
                    d.DeviceId.Contains(searchString) ||
                    d.Made.Contains(searchString) ||
                    d.Model.Contains(searchString) ||
                    d.OS.Contains(searchString) ||
                    d.User.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "deviceId_desc":
                    devices = devices.OrderByDescending(d => d.DeviceId);
                    break;
                case "Model":
                    devices = devices.OrderBy(d => d.Model);
                    break;
                case "model_desc":
                    devices = devices.OrderByDescending(d => d.Model);
                    break;
                case "Made":
                    devices = devices.OrderBy(d => d.Made);
                    break;
                case "made_desc":
                    devices = devices.OrderByDescending(d => d.Made);
                    break;
                case "OS":
                    devices = devices.OrderBy(d => d.OS);
                    break;
                case "os_desc":
                    devices = devices.OrderByDescending(d => d.OS);
                    break;
                case "ScreenSize":
                    devices = devices.OrderBy(d => d.ScreenSize);
                    break;
                case "screen_size_desc":
                    devices = devices.OrderByDescending(d => d.ScreenSize);
                    break;
                case "User":
                    devices = devices.OrderBy(d => d.User);
                    break;
                case "user_desc":
                    devices = devices.OrderByDescending(d => d.User);
                    break;
                case "Checkout":
                    devices = devices.OrderBy(d => d.CheckOutTime);
                    break;
                case "checkout_desc":
                    devices = devices.OrderByDescending(d => d.CheckOutTime);
                    break;
                default:
                    devices = devices.OrderBy(d => d.DeviceId);
                    break;
            }

            return View(devices.ToList());
        }

        // GET: Devices/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Device device = db.Devices.Find(id);
            if (device == null)
            {
                return HttpNotFound();
            }
            return View(device);
        }

        // GET: Devices/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Devices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,DeviceId,Model,Made,OS,ScreenSize,User,CheckOutTime")] Device device)
        {
            if (ModelState.IsValid)
            {
                db.Devices.Add(device);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(device);
        }

        // GET: Devices/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Device device = db.Devices.Find(id);
            if (device == null)
            {
                return HttpNotFound();
            }
            return View(device);
        }

        // POST: Devices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,DeviceId,Model,Made,OS,ScreenSize,User,CheckOutTime")] Device device)
        {
            if (ModelState.IsValid)
            {
                db.Entry(device).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(device);
        }

        // GET: Devices/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Device device = db.Devices.Find(id);
            if (device == null)
            {
                return HttpNotFound();
            }
            return View(device);
        }

        // POST: Devices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Device device = db.Devices.Find(id);
            db.Devices.Remove(device);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
