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
    public class PARTNERSController : ApiController
    {
        private GiveAIDdbEntities db = new GiveAIDdbEntities();

        // GET: api/PARTNERS
        public IQueryable<PARTNERS> GetPARTNERS()
        {
            return db.PARTNERS;
        }

        // GET: api/PARTNERS/5
        [ResponseType(typeof(PARTNERS))]
        public IHttpActionResult GetPARTNERS(int id)
        {
            PARTNERS pARTNERS = db.PARTNERS.Find(id);
            if (pARTNERS == null)
            {
                return NotFound();
            }

            return Ok(pARTNERS);
        }

        // PUT: api/PARTNERS/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPARTNERS(int id, PARTNERS pARTNERS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pARTNERS.id)
            {
                return BadRequest();
            }

            db.Entry(pARTNERS).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PARTNERSExists(id))
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

        // POST: api/PARTNERS
        [ResponseType(typeof(PARTNERS))]
        public IHttpActionResult PostPARTNERS(PARTNERS pARTNERS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PARTNERS.Add(pARTNERS);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pARTNERS.id }, pARTNERS);
        }

        // DELETE: api/PARTNERS/5
        [ResponseType(typeof(PARTNERS))]
        public IHttpActionResult DeletePARTNERS(int id)
        {
            PARTNERS pARTNERS = db.PARTNERS.Find(id);
            if (pARTNERS == null)
            {
                return NotFound();
            }

            db.PARTNERS.Remove(pARTNERS);
            db.SaveChanges();

            return Ok(pARTNERS);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PARTNERSExists(int id)
        {
            return db.PARTNERS.Count(e => e.id == id) > 0;
        }
    }
}