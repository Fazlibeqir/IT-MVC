using Lab3B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3B.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return RedirectToAction("Search");
        }
        public ActionResult Search(string q)
        {
            var albums = new List<Album>
            {
             new Album {Title = "Experience1"},
             new Album {Title = "Experience2"},
             new Album {Title = "Experience3"},
             new Album {Title = "Experience4"}
            };
            var resultAlbum = new List<Album>();
            foreach (Album a in albums)
            {
                if ( a.Title != null && q != null && a.Title.Contains(q))
                {
                    resultAlbum.Add(a);
                }
            }
            return View(resultAlbum);
        }
    }
}