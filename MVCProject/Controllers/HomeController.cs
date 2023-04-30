using Microsoft.AspNetCore.Mvc;
using MVCProject.Data;
using MVCProject.Models;
using System.Diagnostics;

namespace MVCProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ContextFile _context;
        public HomeController(ILogger<HomeController> logger,ContextFile context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AddProduct(Product product)
        {
            if(product.ProductName !=null)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("AddProduct");

            }
            return View(product);
        }
        public IActionResult AddCategory(Category category)
        {
            if (category.CategoryName != null)
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(category);
        }
        public IActionResult DeleteProduct(int ProductId)
        {
      
            var pro = _context.Products.FirstOrDefault(x => x.ProductId == ProductId);
            
            if (pro != null)
            {
                _context.Products.Remove(pro);
                _context.SaveChanges();
                return RedirectToAction("DeleteProduct");
            }
            return View(); 

        }
        public IActionResult DeleteCategory(int CategoryId)
        {
            var cat = _context.Categories.FirstOrDefault(x => x.CategoryId == CategoryId);

            if (cat != null)
            {
                _context.Categories.Remove(cat);
                _context.SaveChanges();
                return RedirectToAction("DeleteCategory");
            }
            return View();
        }
        public IActionResult Getproduct()
        {
            var products = _context.Products.ToList();
            var categories = _context.Categories.ToList();

            var newList = from p in products
                          join c in categories on p.CategoryId equals c.CategoryId
                          select new ProductDto 
                          {
                            ProductId =  p.ProductId,
                            ProductName =  p.ProductName,
                            CategoryId =  c.CategoryId,
                             CategoryName =  c.CategoryName

                          };

            return View(newList.ToList());
            //return View(products);
        }
        public IActionResult UpdateProduct(Product product)
        {
            var pro = _context.Products.FirstOrDefault(x => x.ProductId == product.ProductId);

            if (pro != null)
            {
          
                pro.ProductId = product.ProductId;
                pro.ProductName = product.ProductName;
                pro.CategoryId = product.CategoryId;

               
                _context.SaveChanges();

                return RedirectToAction("UpdateProduct");

            }
            return View(pro);
        }
   
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}