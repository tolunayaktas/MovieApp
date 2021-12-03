using Microsoft.EntityFrameworkCore;
using MovieApp101.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp101.Data
{
    public class MovieContext: DbContext
    {

        public MovieContext(DbContextOptions<MovieContext>options):base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        //public DbSet<Titles> Titles { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Person> People { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("Data Source=movies.db");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().Property(b => b.Title).IsRequired();
            modelBuilder.Entity<Movie>().Property(b => b.Title).HasMaxLength(500);
            modelBuilder.Entity<Genre>().Property(b => b.Name).IsRequired();
            modelBuilder.Entity<Genre>().Property(b => b.Name).HasMaxLength(50);


        }

    }
}
