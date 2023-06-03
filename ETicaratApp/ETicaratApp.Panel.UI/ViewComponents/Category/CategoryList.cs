using ETicaretApp_BusinessLayer.Concrete;
using ETicaretApp_DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ETicaratApp.Panel.UI.ViewComponents.Category
{
    public class CategoryList:ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());

        public IViewComponentResult Invoke()
        {
            var values = cm.GetAll();

            return View(values);
        }
    }
}
