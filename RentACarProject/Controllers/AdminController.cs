using Microsoft.AspNetCore.Mvc;

namespace RentACarProject.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
