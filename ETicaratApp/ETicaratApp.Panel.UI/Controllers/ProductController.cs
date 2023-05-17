using Microsoft.AspNetCore.Mvc;

namespace ETicaratApp.Panel.UI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
