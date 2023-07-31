using Microsoft.AspNetCore.Mvc;
namespace Zakrytie.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
