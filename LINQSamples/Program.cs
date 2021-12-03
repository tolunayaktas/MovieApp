using LINQSamples.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQSamples
{

    class ProductModel
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadLine(); 

        }

        private static void Ders1(NorthwindContext db)
        {
            //var products = db.Products.ToList();
            //var products = db.Products.Select(p => p.ProductName).ToList();
            //var products = db.Products.Select(p => new ProductModel {Name = p.ProductName, Price = p.UnitPrice } ).ToList();


            var product = db.Products.First();
            Console.WriteLine(product.ProductName + ' ' + product.UnitPrice);

            //foreach (var p in products)
            //{
            //    Console.WriteLine(p.Name + ' ' + p.Price);
            //}
        }
    }
}
