﻿using Microsoft.AspNetCore.Mvc;
using MovieApp101.Data;
using MovieApp101.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp101.ViewComponents
{
    public class GenresViewComponent : ViewComponent
    {
        private readonly MovieContext _context;
        public GenresViewComponent(MovieContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedGenre = RouteData.Values["id"];
            return View(_context.Genres.ToList());
        }
    }
}
