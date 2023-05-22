using Microsoft.AspNetCore.Mvc;

namespace ETicaratApp.Panel.UI.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult OrderDetail()
        {
            return View();
        }
    }
}
