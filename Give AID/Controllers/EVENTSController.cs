using Give_AID.Models;
using Newtonsoft.Json;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;


namespace Give_AID.Controllers
{

    public class EVENTSController : ApiController
    {
        private GiveAIDdbEntities db = new GiveAIDdbEntities();

        // GET: api/EVENTS
        public IQueryable<EVENTS> GetEVENTS()
        {
            return db.EVENTS;
        }

        // GET: api/EVENTS/5
        [ResponseType(typeof(EVENTS))]
        public IHttpActionResult GetEVENTS(int id)
        {
            EVENTS eVENTS = db.EVENTS.Find(id);
            if (eVENTS == null)
            {
                return NotFound();
            }

            return Ok(eVENTS);
        }

        // PUT: api/EVENTS/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEVENTS(int id, EVENTS eVENTS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eVENTS.id)
            {
                return BadRequest();
            }

            db.Entry(eVENTS).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EVENTSExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/EVENTS
        [ResponseType(typeof(EVENTS))]
        public IHttpActionResult PostEVENTS()
        {
            var req = HttpContext.Current.Request;
            var file = req.Files.Count > 0 ?
            req.Files[0] : null;
            
            if (file != null && file.ContentLength > 0)
            {
                using (Image image = Image.FromStream(file.InputStream, true, true))
                {
                    using (MemoryStream m = new MemoryStream())
                    {
                        image.Save(m, image.RawFormat);
                        byte[] imageBytes = m.ToArray();

                        // Convert byte[] to Base64 String
                        string base64String = Convert.ToBase64String(imageBytes);
                        EVENTS ev = new EVENTS()
                        {
                            event_title = req.Form["event_title"],
                            event_date = Convert.ToDateTime(req.Form["event_date"]),
                            event_description = req.Form["event_description"],
                            event_poster = "data:imagejpeg;charset=utf-8;base64," + base64String
                        };

                        db.EVENTS.Add(ev);
                        db.SaveChanges();
                        return Ok("Record Added");
                    }
                }
            }

            //return CreatedAtRoute("DefaultApi", new { id = eVENTS.id }, eVENTS);
            return BadRequest("Server Error");
        }

        // DELETE: api/EVENTS/5
        [ResponseType(typeof(EVENTS))]
        public IHttpActionResult DeleteEVENTS(int id)
        {
            EVENTS eVENTS = db.EVENTS.Find(id);
            if (eVENTS == null)
            {
                return NotFound();
            }

            db.EVENTS.Remove(eVENTS);
            db.SaveChanges();

            return Ok(eVENTS);
        }
        [Route(@"api/EVENTS/GetPoster/{id}")]
        public IHttpActionResult GetPoster(int id)
        {
            var event_poster = db.EVENTS.Find(id).event_poster;
            var path = HttpContext.Current.Server.MapPath("~/App_Data/Event_Posters/" + event_poster);
            using (Image image = Image.FromFile(path))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();

                    // Convert byte[] to Base64 String
                    string base64String = Convert.ToBase64String(imageBytes);
                    return Ok("data:imagejpeg;charset=utf-8;base64," + base64String);
                }
            }
            
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EVENTSExists(int id)
        {
            return db.EVENTS.Count(e => e.id == id) > 0;
        }
    }
}