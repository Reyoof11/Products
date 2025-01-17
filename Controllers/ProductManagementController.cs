using Microsoft.AspNetCore.Mvc;
using Products.Data;
using Products.Models;
using System.Linq;

namespace Products.Controllers
{
    public class ProductManagementController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductManagementController(ApplicationDbContext context)
        {
            _context = context;
        }

        // عرض صفحة إضافة المنتجات
        [HttpGet]
        public IActionResult CreateProduct()
        {
            var products = _context.Products.ToList(); // تغيير Products1 إلى Products
            return View(products);
        }

        // إضافة منتج جديد
        [HttpPost]
        public IActionResult CreateProduct(Products1 product) // تغيير Products1 إلى Product
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product); // تغيير Products1 إلى Products
                _context.SaveChanges();
                return RedirectToAction("CreateProduct");
            }

            var products = _context.Products.ToList(); // تغيير Products1 إلى Products
            return View(products);
        }

        // تعديل منتج
        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id); // تغيير Products1 إلى Products
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        public IActionResult EditProduct(Products1 updatedProduct) // تغيير Products1 إلى Product
        {
            if (ModelState.IsValid)
            {
                _context.Products.Update(updatedProduct); // تغيير Products1 إلى Products
                _context.SaveChanges();
                return RedirectToAction("CreateProduct");
            }
            return View(updatedProduct);
        }

        // حذف منتج
        [HttpPost]
        public IActionResult DeleteProduct(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id); // تغيير Products1 إلى Products
            if (product != null)
            {
                _context.Products.Remove(product); // تغيير Products1 إلى Products
                _context.SaveChanges();
            }
            return RedirectToAction("CreateProduct");
        }
    }
}
