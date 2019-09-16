using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCatalog.Service
{
    public class MyDbContext : DbContext
    {
        public DbSet <Product> Produits{ get; set; }
        public DbSet<Category> Categories{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .\\SQLEXPRESS;Database=Catalogue;Trusted_Connection=True");
        }

    }
}
