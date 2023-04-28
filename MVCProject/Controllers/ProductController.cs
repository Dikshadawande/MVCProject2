using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }


    }
}
