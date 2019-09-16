using MyCatalog.Service;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new MyDbContext()) {
               // db.Database.EnsureDeleted();
              //  db.Database.EnsureCreated();
               /* db.Categories.Add(new Category {Categoryname="Ordinateur" });
                db.Categories.Add(new Category { Categoryname = "Smartphone" });
                db.Categories.Add(new Category { Categoryname = "Imprimante" });*/
                db.Produits.Add(new Product { Designation = "HP 65 90 ", price = 7800, Quantite = 6, CategoryId = 1 });
                db.Produits.Add(new Product { Designation = "Samsung ", price = 5800, Quantite = 12, CategoryId = 2 });
                db.Produits.Add(new Product { Designation = "Lazer Jt ", price = 2800, Quantite = 16, CategoryId = 3 });

                db.SaveChanges();
            }
        }
    }
}
