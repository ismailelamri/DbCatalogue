using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCatalog.Service;

namespace MyCatalog.Controllers
{
    public class ProduitController : Controller
    {
        public MyDbContext DbContext { get; set; }

        public ProduitController(MyDbContext db)
        {
            this.DbContext = db;  
        }
        public IActionResult Index(int page = 0, int size = 5,string motCle = "")
        {
            int position = page * size;
            IEnumerable<Product> produits = DbContext.Produits
                .Where(p=>p.Designation.Contains(motCle))
                .Skip(position)
                .Take(size)
                .Include(p=>p.Category)
                .ToList();

            ViewBag.currentPage = page;
            int lenghtOfList = DbContext.Produits.Where(p => p.Designation.Contains(motCle)).ToList().Count % size;
            int totalPages = DbContext.Produits.Where(p => p.Designation.Contains(motCle)).ToList().Count / size;
            ViewBag.totalPages = (lenghtOfList == 0) ? totalPages : totalPages + 1;
            ViewBag.motCle = motCle;
            return View("Produits",produits);
        }

        public IActionResult CreateFrom()
        {
            Product p = new Product();
            Categorie();
            return View("CreateFrom", p);
        }


        [HttpPost]
        public IActionResult SaveProduit(Product p,string Designation)
        {
            Product produit = DbContext.Produits.Find(Designation);

            if (ModelState.IsValid && ! p.Designation.Equals(produit))
            {
                DbContext.Produits.Add(p);
                DbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                Categorie();
                return View("CreateFrom");

            }
        }
        public IActionResult EditFrom(int? ProductId)
        {
            Product p = DbContext.Produits.Find(ProductId);
            Categorie();
            return View("EditFrom",p);
        }


        [HttpPost]
        public IActionResult Editsave(Product p)
        {
            
            DbContext.Produits.Update(p);
            DbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public void Categorie()
        {
            IEnumerable<Category> cats = DbContext.Categories.ToList();
            ViewBag.categories = cats;
        }

        public IActionResult DeleteForm(int? ProductId)
        {
            Product p = DbContext.Produits.Find(ProductId);
            Categorie();
            return View("DeleteForm",p);
        }

        public IActionResult DeleteItem(Product p)
        {
            DbContext.Produits.Remove(p);
            DbContext.SaveChanges();
            return RedirectToAction("Index");
        }

     
        public IActionResult DetailsProduct(int? ProductId)
        { 
           Product p = DbContext.Produits.Find(ProductId);
            Categorie();
            return View("DetailsProduct");
        }
        public IActionResult ToSwitch()
        {
            return RedirectToAction("Categorie","Category");
        }
       
    }
}