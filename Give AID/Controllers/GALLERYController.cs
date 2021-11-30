using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Give_AID.Models;

namespace Give_AID.Controllers
{
    public class GALLERYController : ApiController
    {
        private GiveAIDdbEntities db = new GiveAIDdbEntities();

        // GET: api/GALLERY
        public IQueryable<GALLERY> GetGALLERY()
        {
            return db.GALLERY;
        }

        // GET: api/GALLERY/5
        [ResponseType(typeof(GALLERY))]
        public IHttpActionResult GetGALLERY(int id)
        {
            GALLERY gALLERY = db.GALLERY.Find(id);
            if (gALLERY == null)
            {
                return NotFound();
            }

            return Ok(gALLERY);
        }

        // PUT: api/GALLERY/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGALLERY(int id, GALLERY gALLERY)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != gALLERY.id)
            {
                return BadRequest();
            }

            db.Entry(gALLERY).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GALLERYExists(id))
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

        // POST: api/GALLERY
        [ResponseType(typeof(GALLERY))]
        public IHttpActionResult PostGALLERY(GALLERY gALLERY)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.GALLERY.Add(gALLERY);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = gALLERY.id }, gALLERY);
        }

        // DELETE: api/GALLERY/5
        [ResponseType(typeof(GALLERY))]
        public IHttpActionResult DeleteGALLERY(int id)
        {
            GALLERY gALLERY = db.GALLERY.Find(id);
            if (gALLERY == null)
            {
                return NotFound();
            }

            db.GALLERY.Remove(gALLERY);
            db.SaveChanges();

            return Ok(gALLERY);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GALLERYExists(int id)
        {
            return db.GALLERY.Count(e => e.id == id) > 0;
        }
    }
}