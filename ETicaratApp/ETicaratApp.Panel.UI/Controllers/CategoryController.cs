using ETicaretApp_BusinessLayer.Concrete;
using ETicaretApp_DataAccess.EntityFramework;
using ETicaretApp_EntityLayer.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ETicaratApp.Panel.UI.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        CategoryPropertyManager cpm = new CategoryPropertyManager(new EfCategoryProperty());
        PropertyValueManager pvm = new PropertyValueManager(new EfPropertyValue());

        public CategoryController(CategoryManager cm, CategoryPropertyManager cpm, PropertyValueManager pvm)
        {
            this.cm = cm;
            this.cpm = cpm;
            this.pvm = pvm;
        }

        public IActionResult Index()
        {
            var values = cm.GetAll();
            return View(values);
        }

        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {         
            cm.Create(category);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCategory(int id)
        {
            Category category = cm.GetById(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult DeleteCategory(Category category)
        {
            cm.Delete(category);
            return RedirectToAction("Index");
        }
    }
}
