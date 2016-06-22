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
using recrutement.DAL;
using recrutement.Models;
using recrutement.ViewModels;

namespace recrutement.api
{
    public class CandidatsController : ApiController
    {
        private recruteContext db = new recruteContext();

        // GET: api/Candidats
        public IQueryable<Candidat> GetCandidats()
        {
            return db.Candidats;
        }

        // GET: api/Candidats/5
        [ResponseType(typeof(Candidat))]
        public IHttpActionResult GetCandidat(int id)
        {
            Candidat candidat = db.Candidats.Find(id);
            if (candidat == null)
            {
                return NotFound();
            }

            return Ok(candidat);
        }

        // PUT: api/Candidats/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCandidat(int id, Candidat candidat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != candidat.ID)
            {
                return BadRequest();
            }

            db.Entry(candidat).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CandidatExists(id))
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

        // POST: api/Candidats
        [ResponseType(typeof(Candidat))]
        public IHttpActionResult PostCandidat(Candidat candidat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //Candidat candidat = new Candidat { FirstName = candi.FirstName[0], LastName = candi.LastName[0], EnrollmentDate = DateTime.Parse(candi.EnrollmentDate[0]).ToString(), Email = candi.Email[0], HomePhone = int.Parse(candi.HomePhone[0]), MobilePhone = int.Parse(candi.MobilePhone[0]), Birthday = DateTime.Parse(candi.Birthday[0]).ToString(), Website = candi.Website[0], Address = candi.Address[0] };

            db.Candidats.Add(candidat);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = candidat.ID }, candidat);
        }

        // DELETE: api/Candidats/5
        [ResponseType(typeof(Candidat))]
        public IHttpActionResult DeleteCandidat(int id)
        {
            Candidat candidat = db.Candidats.Find(id);
            if (candidat == null)
            {
                return NotFound();
            }

            db.Candidats.Remove(candidat);
            db.SaveChanges();

            return Ok(candidat);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CandidatExists(int id)
        {
            return db.Candidats.Count(e => e.ID == id) > 0;
        }
    }
}