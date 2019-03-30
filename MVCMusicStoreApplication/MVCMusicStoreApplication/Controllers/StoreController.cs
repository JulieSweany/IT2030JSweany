using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStoreApplication.Models;

namespace MVCMusicStoreApplication.Controllers
{
    public class StoreController : Controller
    {
        private MVCMusicStoreDB db = new MVCMusicStoreDB();

        // GET: Store/Browse
        public ActionResult Browse()
        {
            var genres = db.Genres.OrderBy(a => a.Name);
            return View(genres.ToList());
        }

        // GET: Store/Index/id
        public ActionResult Index(int id)
        {
            var albumsByGenre = db.Albums.Where(a => a.Genre.GenreId == id).OrderBy(a => a.Title);
            return View(albumsByGenre.ToList());
        }

        // GET: Store/Details/id
        public ActionResult Details(int id)
        {
            Album album = db.Albums.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }
    }
    
}