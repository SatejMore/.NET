using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            var movies = new List<Movie>{
                new Movie { Id =1 , Name="Shreak"},
                new Movie {Id=2 , Name="Wall-E" }
            };
            return movies;
        }


        //public ActionResult Edit(int id)
        //{
        //    return Content(string.Format("Id={0}", id));
        //}

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";
        //    return Content(string.Format("PageIndex={0} , SortBy={1}", pageIndex, sortBy));
        //}

        //[Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        //public ActionResult ReleaseByMonth(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}

    }
}