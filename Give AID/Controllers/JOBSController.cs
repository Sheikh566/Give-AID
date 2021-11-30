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
    public class JOBSController : ApiController
    {
        private GiveAIDdbEntities db = new GiveAIDdbEntities();

        // GET: api/JOBS
        public IQueryable<JOBS> GetJOBS()
        {
            return db.JOBS;
        }

        // GET: api/JOBS/5
        [ResponseType(typeof(JOBS))]
        public IHttpActionResult GetJOBS(int id)
        {
            JOBS jOBS = db.JOBS.Find(id);
            if (jOBS == null)
            {
                return NotFound();
            }

            return Ok(jOBS);
        }

        // PUT: api/JOBS/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutJOBS(int id, JOBS jOBS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != jOBS.id)
            {
                return BadRequest();
            }

            db.Entry(jOBS).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JOBSExists(id))
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

        // POST: api/JOBS
        [ResponseType(typeof(JOBS))]
        public IHttpActionResult PostJOBS(JOBS jOBS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.JOBS.Add(jOBS);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = jOBS.id }, jOBS);
        }

        // DELETE: api/JOBS/5
        [ResponseType(typeof(JOBS))]
        public IHttpActionResult DeleteJOBS(int id)
        {
            JOBS jOBS = db.JOBS.Find(id);
            if (jOBS == null)
            {
                return NotFound();
            }

            db.JOBS.Remove(jOBS);
            db.SaveChanges();

            return Ok(jOBS);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool JOBSExists(int id)
        {
            return db.JOBS.Count(e => e.id == id) > 0;
        }
    }
}