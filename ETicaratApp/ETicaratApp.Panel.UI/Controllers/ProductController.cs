﻿using ETicaretApp_BusinessLayer.Abstract;
using ETicaretApp_BusinessLayer.Concrete;
using ETicaretApp_DataAccess.Concrete;
using ETicaretApp_DataAccess.EntityFramework;
using ETicaretApp_EntityLayer.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection.Metadata;

namespace ETicaratApp.Panel.UI.Controllers
{
    public class ProductController : Controller
    {
        //private IProductService _productService;
        private readonly IWebHostEnvironment webHostEnvironment;

        ProductManager productManager = new ProductManager
            (new EfProductRepository());
        CategoryManager categoryManager = new CategoryManager
            (new EfCategoryRepository());

        public ProductController(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }

        //public ProductController(IProductService productService)
        //{
        //    _productService = productService;
        //}

        public IActionResult Index()
        {
            List<Product> list = productManager.GetAll();
            return View(list);
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product, IFormFile file)
        {
            product.ImageUrl = "";
            if (file != null)
            {
                string wwwrootPath = webHostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(file.FileName);
                string extension = Path.GetExtension(file.FileName);

                string yeniDosyaAdi = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwrootPath + "/images/product/", yeniDosyaAdi);

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                product.ImageUrl = yeniDosyaAdi;
            }

<<<<<<< HEAD


=======
            List<SelectListItem> categoryvalues = (from x in
                  categoryManager.GetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.Id.ToString()
                                                   }).ToList();
            ViewBag.CategoryValues = categoryvalues;
>>>>>>> 68ac2f0184b0492aaaa8dff992c7e6aac35d4f9f
            productManager.Create(product);
            return RedirectToAction("Index");
        }

        public IActionResult EditProduct(int id)
        {
            Product product = productManager.GetById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult EditProduct(Product product, IFormFile? file)
        {
            if (file != null)
            {
                string wwwrootPath = webHostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(file.FileName);
                string extension = Path.GetExtension(file.FileName);

                string yeniDosyaAdi = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwrootPath + "/images/product/", yeniDosyaAdi);

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                product.ImageUrl = yeniDosyaAdi;
            }
            productManager.Update(product);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeleteProduct(int id)
        {
            Product product = productManager.GetById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult DeleteProduct(Product product)
        {
            productManager.Delete(product);
            return RedirectToAction("Index");
        }

    }
}
