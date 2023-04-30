using Microsoft.AspNetCore.Mvc;
using MVCProject.Data;
using MVCProject.Models;

namespace MVCProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly ContextFile _context;

        public ProductController(ContextFile context)
        {
            _context = context;

        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

            return View();
        }


    }
}
