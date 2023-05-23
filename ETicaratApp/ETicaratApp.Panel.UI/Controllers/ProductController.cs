using ETicaretApp_BusinessLayer.Concrete;
using ETicaretApp_DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ETicaratApp.Panel.UI.Controllers
{
    public class ProductController : Controller
    {//
        public IActionResult Index()
        {
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
