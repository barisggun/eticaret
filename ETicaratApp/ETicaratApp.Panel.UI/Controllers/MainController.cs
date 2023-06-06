using ETicaratApp.Panel.UI.Models;
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
        CategoryPropertyManager propertyManager = new CategoryPropertyManager(new EfCategoryProperty());
        PropertyValueManager propertyValueManager = new PropertyValueManager(new EfPropertyValue());
        public IActionResult Index()
        {
            List<Product> list = pm.GetProductListWithCategory();
            return View(list);
            //var values = pm.GetProductListWithCategory();
            //return View(values);
        }

        public IActionResult ProductReadAll(int id)
        {
            //ViewBag.i = id;
            //var values = pm.GetById(id);
            //return View(values);

            var productId = pm.GetById(id);
            return View(pm.GetAll().Where(x => x.Id == id).ToList());
        }

        public IActionResult AdditionalInformationPartial(int id)
        {
            var product = pm.GetById(id);
            var properties = propertyManager.GetAll().Where(x => x.CategoryId == product.CategoryId).ToList();

            List<ProductProperty> productProperty = new List<ProductProperty>();
            foreach (var property in properties)
            {
                var value = "";
                if (propertyValueManager.GetAll().Any(x => x.ProductId == product.Id && x.CategoryPropertyId == property.Id))
                {
                    value = propertyValueManager.GetAll().FirstOrDefault(x => x.ProductId == product.Id && x.CategoryPropertyId == property.Id).Value;
                }
                productProperty.Add(new ProductProperty
                {
                    Id = property.Id.ToString(),
                    ProductId = product.Id,
                    PropertyName = property.PropertyName,
                    Value = value

                });
            }

            return PartialView("_AdditionalInformationPartial", productProperty);

        }
    }
}
