using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            Movie movieObject = new Movie { Name = "Drishyam", Id = 1 };
            return View(movieObject);
        }
    }
}