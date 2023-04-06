using Microsoft.AspNetCore.Mvc;

namespace myfirstWebApp.Controllers
{
    public class NistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
