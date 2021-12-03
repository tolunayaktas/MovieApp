using Microsoft.AspNetCore.Mvc;
using MovieApp101.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp101.Models
{
    public class UserModel
    {
        
        public int UserId { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Kullanıcı adı 15 karakterden fazla olamaz")]
        [Remote(action:"VerifyUserName", controller:"User")]
        public string UserName { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "{0} karakter uzunluğu {2}-{1} arasında olmalıdır. ", MinimumLength=3)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [EmailProviders]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string RePassword { get; set; }
        [Url]
        public string Url { get; set; }
        //[Range(1920,2010)]
        //public int BirthYear { get; set; }
        [BirthDate (ErrorMessage = "Doğum tarihiniz geçersiz.")]
        [DataType(DataType.Date)]
        [Display(Name="Birth Date")]
        public DateTime BirthDate { get; set; }
    }
}
