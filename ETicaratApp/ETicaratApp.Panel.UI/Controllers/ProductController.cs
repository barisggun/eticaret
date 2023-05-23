using ETicaretApp_BusinessLayer.Concrete;
using ETicaretApp_DataAccess.Concrete;
using ETicaretApp_DataAccess.EntityFramework;
using ETicaretApp_EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ETicaratApp.Panel.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly Context context;

        public ProductController(Context context, ProductManager productManager)
        {
            this.context = context;
            this.productManager = productManager;
        }

        ProductManager productManager = new ProductManager
            (new EfProductRepository());

        public IActionResult Index()
        {
            List<Product> list = productManager.GetAll();
            return View();
        }
        
        public IActionResult AddProduct()
        {
            return View();
        }
        
        public IActionResult EditProduct()
        {
            return View();
        }
    }
}
