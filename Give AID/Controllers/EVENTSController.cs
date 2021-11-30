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
        public IHttpActionResult PostEVENTS(EVENTS eVENTS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EVENTS.Add(eVENTS);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = eVENTS.id }, eVENTS);
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