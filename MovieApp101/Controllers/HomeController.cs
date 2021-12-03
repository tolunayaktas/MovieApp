using Microsoft.AspNetCore.Mvc;
using MovieApp101.Data;
using MovieApp101.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp101.Controllers
{
    public class HomeController : Controller
    {
        private readonly MovieContext _context;
        public HomeController(MovieContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            var model = new HomePageViewModel
            {
                PopularMovies = _context.Movies.ToList()
            };
            

            return View(model);
        }
        public IActionResult About()
        {
            
            return View();
        }
    }
}
