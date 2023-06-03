using ETicaretApp_BusinessLayer.Concrete;
using ETicaretApp_DataAccess.EntityFramework;
using ETicaretApp_EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ETicaratApp.Panel.UI.Controllers
{
    public class MainController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductRepository());
        CategoryManager categoryManager = new CategoryManager
            (new EfCategoryRepository());
        public IActionResult Index()
        {
            List<Product> list = pm.GetProductListWithCategory();
            return View(list);
            //var values = pm.GetProductListWithCategory();
            //return View(values);
        }
    }
}
