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
    public class FEEDBACKSController : ApiController
    {
        private GiveAIDdbEntities db = new GiveAIDdbEntities();

        // GET: api/FEEDBACKS
        public IQueryable<FEEDBACKS> GetFEEDBACKS()
        {
            return db.FEEDBACKS;
        }

        // GET: api/FEEDBACKS/5
        [ResponseType(typeof(FEEDBACKS))]
        public IHttpActionResult GetFEEDBACKS(int id)
        {
            FEEDBACKS fEEDBACKS = db.FEEDBACKS.Find(id);
            if (fEEDBACKS == null)
            {
                return NotFound();
            }

            return Ok(fEEDBACKS);
        }

        // PUT: api/FEEDBACKS/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFEEDBACKS(int id, FEEDBACKS fEEDBACKS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != fEEDBACKS.id)
            {
                return BadRequest();
            }

            db.Entry(fEEDBACKS).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FEEDBACKSExists(id))
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

        // POST: api/FEEDBACKS
        [ResponseType(typeof(FEEDBACKS))]
        public IHttpActionResult PostFEEDBACKS(FEEDBACKS fEEDBACKS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.FEEDBACKS.Add(fEEDBACKS);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = fEEDBACKS.id }, fEEDBACKS);
        }

        // DELETE: api/FEEDBACKS/5
        [ResponseType(typeof(FEEDBACKS))]
        public IHttpActionResult DeleteFEEDBACKS(int id)
        {
            FEEDBACKS fEEDBACKS = db.FEEDBACKS.Find(id);
            if (fEEDBACKS == null)
            {
                return NotFound();
            }

            db.FEEDBACKS.Remove(fEEDBACKS);
            db.SaveChanges();

            return Ok(fEEDBACKS);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FEEDBACKSExists(int id)
        {
            return db.FEEDBACKS.Count(e => e.id == id) > 0;
        }
    }
}