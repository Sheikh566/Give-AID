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
    public class CAUSESController : ApiController
    {
        private GiveAIDdbEntities db = new GiveAIDdbEntities();

        // GET: api/CAUSES
        public IQueryable<CAUSES> GetCAUSES()
        {
            return db.CAUSES;
        }

        // GET: api/CAUSES/5
        [ResponseType(typeof(CAUSES))]
        public IHttpActionResult GetCAUSES(int id)
        {
            CAUSES cAUSES = db.CAUSES.Find(id);
            if (cAUSES == null)
            {
                return NotFound();
            }

            return Ok(cAUSES);
        }

        // PUT: api/CAUSES/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCAUSES(int id, CAUSES cAUSES)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cAUSES.id)
            {
                return BadRequest();
            }

            db.Entry(cAUSES).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CAUSESExists(id))
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

        // POST: api/CAUSES
        [ResponseType(typeof(CAUSES))]
        public IHttpActionResult PostCAUSES(CAUSES cAUSES)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CAUSES.Add(cAUSES);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = cAUSES.id }, cAUSES);
        }

        // DELETE: api/CAUSES/5
        [ResponseType(typeof(CAUSES))]
        public IHttpActionResult DeleteCAUSES(int id)
        {
            CAUSES cAUSES = db.CAUSES.Find(id);
            if (cAUSES == null)
            {
                return NotFound();
            }

            db.CAUSES.Remove(cAUSES);
            db.SaveChanges();

            return Ok(cAUSES);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CAUSESExists(int id)
        {
            return db.CAUSES.Count(e => e.id == id) > 0;
        }
    }
}