using MovieApp101.Entity;
using MovieApp101.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp101.Models
{
    public class AdminMoviesViewModel
    {
        public List<AdminMovieViewModel> Movies { get; set; }
    }
    public class AdminMovieViewModel
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public List<Genre> Genres { get; set; }


    }
    public class AdminCreateMovieModel
    {
        [Display(Name = "Film Adı")]
        [Required(ErrorMessage ="Film adı girmelisiniz.")]
        [StringLength(50, MinimumLength =1, ErrorMessage ="Lütfen 1-50 karakter uzunluğunda giriniz.")]
        public string Title { get; set; }
        [Display(Name = "Film Açıklaması")]
        [Required(ErrorMessage = "Film açıklaması girmelisiniz.")]
        [StringLength(3000, MinimumLength = 10, ErrorMessage = "Lütfen 10-3000 karakter uzunluğunda giriniz.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "En az bir tür seçmelisiniz.")]
        public int[] GenreIds { get; set; }
        public bool IsClassic { get; set; }
        [ClassicMovie(1960)]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; } = DateTime.Now;
    }
    public class AdminEditMovieViewModel
    {
        public int MovieId { get; set; }
        [Display(Name = "Film Adı")]
        [Required(ErrorMessage = "Film adı girmelisiniz.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Lütfen 1-50 karakter uzunluğunda giriniz.")]
        public string Title { get; set; }
        [Display(Name = "Film Açıklaması")]
        [Required(ErrorMessage = "Film açıklaması girmelisiniz.")]
        [StringLength(3000, MinimumLength = 10, ErrorMessage = "Lütfen 10-3000 karakter uzunluğunda giriniz.")]
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "En az bir tür seçmelisiniz.")]
        public int[] GenreIds { get; set; }

    }
}
