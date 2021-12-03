﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieApp101.Data;
using MovieApp101.Entity;
using MovieApp101.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp101.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieContext _context;
        public MoviesController(MovieContext context)
        {
            _context = context;
        }



        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List(int? id, string q)
        {


            var movies = _context.Movies.AsQueryable();
            

            if (id != null)
            {
                movies = movies.Include(m=> m.Genres)
                    .Where(m => m.Genres.Any(g=>g.GenreId==id));
            }

            if (!string.IsNullOrEmpty(q))
            {
                movies = movies.Where(i => i.Title.ToLower().Contains(q.ToLower()) || i.Description.ToLower().Contains(q.ToLower()));
            }


            var model = new MoviesViewModel()
            {

                Movies = movies.ToList()

            };
            return View("Movies", model);
        }
        public IActionResult Details(int id)
        {
            return View(_context.Movies.Find(id));
        }
        
    }
}


