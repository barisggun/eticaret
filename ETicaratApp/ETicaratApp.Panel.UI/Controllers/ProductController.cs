using ETicaretApp_BusinessLayer.Abstract;
using ETicaretApp_BusinessLayer.Concrete;
using ETicaretApp_DataAccess.Concrete;
using ETicaretApp_DataAccess.EntityFramework;
using ETicaretApp_EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ETicaratApp.Panel.UI.Controllers
{
    public class ProductController : Controller
    {
        //private IProductService _productService;

        ProductManager productManager = new ProductManager
            (new EfProductRepository());

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
        public IActionResult AddProduct(Product product)
        {
            productManager.Create(product);
            return RedirectToAction("Index");
        }
        
        public IActionResult EditProduct(int id)
        {
            Product product = productManager.GetById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
                productManager.Update(product);
                return RedirectToAction("Index");
            

            
            //return View(product);
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
