using Microsoft.AspNetCore.Mvc;

namespace TailorManagementAPI.Controllers
{
    public class Customer : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
