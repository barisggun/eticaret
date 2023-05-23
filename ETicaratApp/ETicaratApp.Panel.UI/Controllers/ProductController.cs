using ETicaretApp_BusinessLayer.Abstract;
using ETicaretApp_BusinessLayer.Concrete;
using ETicaretApp_DataAccess.Concrete;
using ETicaretApp_DataAccess.EntityFramework;
using ETicaretApp_EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

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

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            return View();
        }
        
        public IActionResult EditProduct()
        {
            return View();
        }
    }
}
