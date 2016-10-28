using Microsoft.AspNetCore.Mvc;

namespace InteractiveTableBootstrap.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Mvc/Views/Home/Index.cshtml");
        }
    }
}
