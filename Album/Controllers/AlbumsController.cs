using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Album.Models;

namespace Album.Controllers
{
    
    public class AlbumsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Albums
  
        public ActionResult Index()
        {
            if (User.IsInRole("User"))
            {
                return View("IndexAjax");
            }
            var albums = db.Albums.Include(a => a.Artist).Include(a => a.Genre);
            return View(albums.ToList());
        }
        public ActionResult IndexAjax()
        {
            return View();
        }

        // GET: Albums/Details/5
        [Authorize(Roles ="User")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Albums albums = db.Albums.Find(id);
            if (albums == null)
            {
                return HttpNotFound();
            }
            return View(albums);
        }

        // GET: Albums/Create
        public ActionResult Create()
        {
            ViewBag.ArtistId = new SelectList(db.Artists, "ArtistId", "Name");
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name");
            return View();
        }

        // POST: Albums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,GenreId,ArtistId,Title,Price,AlbumArtUrl,Name")] Albums albums)
        {
            if (ModelState.IsValid)
            {
                db.Albums.Add(albums);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ArtistId = new SelectList(db.Artists, "ArtistId", "Name", albums.ArtistId);
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name", albums.GenreId);
            return View(albums);
        }

        // GET: Albums/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Albums albums = db.Albums.Find(id);
            if (albums == null)
            {
                return HttpNotFound();
            }
            ViewBag.ArtistId = new SelectList(db.Artists, "ArtistId", "Name", albums.ArtistId);
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name", albums.GenreId);
            return View(albums);
        }

        // POST: Albums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,GenreId,ArtistId,Title,Price,AlbumArtUrl")] Albums albums)
        {
            if (ModelState.IsValid)
            {
                db.Entry(albums).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ArtistId = new SelectList(db.Artists, "ArtistId", "Name", albums.ArtistId);
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name", albums.GenreId);
            return View(albums);
        }

        // GET: Albums/Delete/5
     
        public ActionResult Delete(int id)
        {

            Albums albums = db.Albums.Find(id);
            db.Albums.Remove(albums);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
