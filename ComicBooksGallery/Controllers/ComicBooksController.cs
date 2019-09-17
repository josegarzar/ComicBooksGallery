using ComicBookGallery.Models;
using ComicBooksGallery.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepo _comicBookRepo = null;

        public ComicBooksController()
        {
            _comicBookRepo = new ComicBookRepo();
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepo.GetComicBook(id.Value);

            return View(comicBook);
        }
    }
}