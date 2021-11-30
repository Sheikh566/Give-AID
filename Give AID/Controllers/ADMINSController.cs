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
    public class ADMINSController : ApiController
    {
        private GiveAIDdbEntities db = new GiveAIDdbEntities();

        // GET: api/ADMINS
        public IQueryable<ADMIN> GetADMIN()
        {
            return db.ADMIN;
        }

        // GET: api/ADMINS/5
        [ResponseType(typeof(ADMIN))]
        public IHttpActionResult GetADMIN(int id)
        {
            ADMIN aDMIN = db.ADMIN.Find(id);
            if (aDMIN == null)
            {
                return NotFound();
            }

            return Ok(aDMIN);
        }

        // PUT: api/ADMINS/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutADMIN(int id, ADMIN aDMIN)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != aDMIN.id)
            {
                return BadRequest();
            }

            db.Entry(aDMIN).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ADMINExists(id))
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

        // POST: api/ADMINS
        [ResponseType(typeof(ADMIN))]
        public IHttpActionResult PostADMIN(ADMIN aDMIN)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ADMIN.Add(aDMIN);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = aDMIN.id }, aDMIN);
        }

        // DELETE: api/ADMINS/5
        [ResponseType(typeof(ADMIN))]
        public IHttpActionResult DeleteADMIN(int id)
        {
            ADMIN aDMIN = db.ADMIN.Find(id);
            if (aDMIN == null)
            {
                return NotFound();
            }

            db.ADMIN.Remove(aDMIN);
            db.SaveChanges();

            return Ok(aDMIN);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ADMINExists(int id)
        {
            return db.ADMIN.Count(e => e.id == id) > 0;
        }
    }
}