using Microsoft.AspNetCore.Mvc;

namespace ETicaratApp.Panel.UI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
