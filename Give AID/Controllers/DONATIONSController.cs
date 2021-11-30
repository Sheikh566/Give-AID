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
using System.Web.Http.Results;
using Give_AID.Models;

namespace Give_AID.Controllers
{
    public class DONATIONSController : ApiController
    {
        private GiveAIDdbEntities db = new GiveAIDdbEntities();

        // GET: api/DONATIONS
        public IQueryable<DONATIONS> GetDONATIONS()
        {
            return db.DONATIONS;
        }

        // GET: api/DONATIONS/5
        [ResponseType(typeof(DONATIONS))]
        public IHttpActionResult GetDONATIONS(int id)
        {
            DONATIONS dONATIONS = db.DONATIONS.Find(id);
            if (dONATIONS == null)
            {
                return NotFound();
            }

            return Ok(dONATIONS);
        }

        // PUT: api/DONATIONS/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDONATIONS(int id, DONATIONS dONATIONS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dONATIONS.id)
            {
                return BadRequest();
            }

            db.Entry(dONATIONS).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DONATIONSExists(id))
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

        // POST: api/DONATIONS
        [ResponseType(typeof(DONATIONS))]
        public IHttpActionResult PostDONATIONS(DONATIONS dONATIONS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DONATIONS.Add(dONATIONS);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = dONATIONS.id }, dONATIONS);
        }

        // DELETE: api/DONATIONS/5
        [ResponseType(typeof(DONATIONS))]
        public BadRequestErrorMessageResult DeleteDONATIONS(int id)
        {
            //DONATIONS dONATIONS = db.DONATIONS.Find(id);
            //if (dONATIONS == null)
            //{
            //    return NotFound();
            //}

            //db.DONATIONS.Remove(dONATIONS);
            //db.SaveChanges();

            //return Ok(dONATIONS);
            return BadRequest("Forbidden: You can't delete donation records");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DONATIONSExists(int id)
        {
            return db.DONATIONS.Count(e => e.id == id) > 0;
        }
    }
}