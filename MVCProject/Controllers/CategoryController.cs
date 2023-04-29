using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCProject.Data;
using MVCProject.Models;

namespace MVCProject.Controllers {
    public class CategoryController : Controller
    {
        private readonly ContextFile _context;
        public CategoryController(ContextFile context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetCategory()
        {
            var catList = await _context.Categories.ToListAsync();
            return View(catList);
        }
        [HttpPost]
        public async Task<IActionResult> AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();

            return View();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var ab = _context.Categories.FirstOrDefault(x => x.CategoryId == id);
             _context.Categories.Remove(ab);
            _context.SaveChanges()
;
            return View();
        }
    }
}
