using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var Movie = new movie()
                {
                Name = "This Shit is real and it works "      
                };
           
            return View(Movie);
            //return new ViewResult();
            //return Content("Hello WEB!");
            //return HttpNotFound();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "Name" });
            }

        public ActionResult Edit(int movieId)
            {
            return Content("id=" + movieId);
            }
    }
}