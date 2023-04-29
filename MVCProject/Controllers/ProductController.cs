using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;

namespace MVCProject.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Add(Product product)
        {
            return View();
        }


    }
}
