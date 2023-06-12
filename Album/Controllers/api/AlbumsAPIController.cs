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
using Album.Models;

namespace Album.Controllers.api
{
    public class AlbumsAPIController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Albums

        public List<AlbumDto> GetAlbums()
        {
            return db.Albums.Select(x=>new AlbumDto{
                Id = x.Id,
                Title = x.Title,
                Price = x.Price,
                AlbumArtUrl = x.AlbumArtUrl
            }).ToList();
        }

        // GET: api/Albums/5
        [ResponseType(typeof(Albums))]
        public IHttpActionResult GetAlbums(int id)
        {
            Albums albums = db.Albums.Find(id);
            if (albums == null)
            {
                return NotFound();
            }

            return Ok(albums);
        }

        // PUT: api/Albums/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAlbums(int id, Albums albums)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != albums.Id)
            {
                return BadRequest();
            }

            db.Entry(albums).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlbumsExists(id))
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

        // POST: api/Albums
        [ResponseType(typeof(Albums))]
        public IHttpActionResult PostAlbums(Albums albums)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Albums.Add(albums);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = albums.Id }, albums);
        }

        // DELETE: api/Albums/5
        [ResponseType(typeof(Albums))]
        public IHttpActionResult DeleteAlbums(int id)
        {
            Albums albums = db.Albums.Find(id);
            if (albums == null)
            {
                return NotFound();
            }

            db.Albums.Remove(albums);
            db.SaveChanges();

            return Ok(albums);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AlbumsExists(int id)
        {
            return db.Albums.Count(e => e.Id == id) > 0;
        }
    }
}