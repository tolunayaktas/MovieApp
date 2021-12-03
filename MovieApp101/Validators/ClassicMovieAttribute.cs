using MovieApp101.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp101.Validators
{
    public class ClassicMovieAttribute : ValidationAttribute
    {
        public ClassicMovieAttribute(int year)
        {
            Year = year;
        }
        public int Year { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (AdminCreateMovieModel)validationContext.ObjectInstance;
            var releaseYear = ((DateTime)value).Year;

            if(movie.IsClassic && releaseYear > Year)
            {
                return new ValidationResult($"Klasik filmler {Year} ve öncesini kapsar.");
            }
            return ValidationResult.Success;
        }
    }
}
