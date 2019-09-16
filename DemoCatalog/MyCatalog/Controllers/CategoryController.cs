using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCatalog.Service;

namespace MyCatalog.Controllers
{
    public class CategoryController : Controller
    {
        public MyDbContext DbContext { get; set; }

        public CategoryController(MyDbContext db)
        {
            this.DbContext = db;
        }

        public IActionResult Categorie(int page = 0, int size = 5)
        {
            int position = page * size ;
            IEnumerable<Category> categories = DbContext.Categories.Skip(position).Take(size).ToList();
            ViewBag.currentPage = page;
            int lenghtOfList = DbContext.Categories.ToList().Count % size;
            int totalPages = DbContext.Categories.ToList().Count / size;
            ViewBag.totalPages = (lenghtOfList == 0) ? totalPages : totalPages + 1;
            return View("Categorie", categories);
        }

        public IActionResult CreateCategory()
        {
            
                Category c = new Category();
                return View("CreateCategory", c);

        }
        [HttpPost]
        public IActionResult SaveCategory(Category c )
        {
            if (ModelState.IsValid)
            {
                DbContext.Categories.Add(c);
                DbContext.SaveChanges();

                return RedirectToAction("Categorie");
            }
            else
            {
                return View("CreateCategory");

            }
        }

        
        public IActionResult EditForm(int? CategoryId)
        {
            Category c = DbContext.Categories.Find(CategoryId);
            return View("EditForm", c);
        }


        [HttpPost] 
        public IActionResult SaveEdit(Category c )
        {
            DbContext.Categories.Update(c);
            DbContext.SaveChanges();
            return RedirectToAction("Categorie");
        }


        public IActionResult DetailsCategory(int? CategoryId)
        {
            Category c = DbContext.Categories.Find(CategoryId);
            return View("DetailsCategory",c);
        }

        public IActionResult DeleteForm(int? CategoryId)
        {
            Category c = DbContext.Categories.Find(CategoryId);
            return View("DeleteForm", c);
        }


        public IActionResult DeleteItem(Category c)
        {
            DbContext.Categories.Remove(c);
            DbContext.SaveChanges();
            return RedirectToAction("Categorie");
        }
    }
}