using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class CategoryController : Controller
    {
        [HttpGet]
        public IActionResult GetCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            return View();
        }
    }
}
