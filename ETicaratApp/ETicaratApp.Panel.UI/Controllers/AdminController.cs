using Microsoft.AspNetCore.Mvc;

namespace ETicaratApp.Panel.UI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Logout()
        {
            //Logout Kodları Buraya
            return View();
        }

        public IActionResult Login()
        {
            //Login Kodları Buraya
            return View();
        }
    }
}
