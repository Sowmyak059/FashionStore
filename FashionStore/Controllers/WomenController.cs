using FashionStore.Data;
using FashionStore.Models;
using FashionStore.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace e_CommerceStore.Controllers
{
    
    public class WomenController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WomenController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var menCategory = _context.MainCategory
                .Include(mc => mc.CategoryHeaders)
                .ThenInclude(ch => ch.Categories)
                .ThenInclude(c => c.Products)
                .FirstOrDefault(mc => mc.Name == "Women");

            if (menCategory == null)
            {
                return NotFound();
            }

            return View(menCategory);
        }

        public IActionResult Products(int categoryID)
        {
            var categoryHeaders = _context.CategoryHeader
                .Include(ch => ch.Categories)
                .ThenInclude(c => c.Products)
                .Where(ch => ch.MainCategory.Name == "Women")
                .ToList();

            var products = _context.Product.Where(p => p.CategoryID == categoryID).ToList();

            var viewModel = new ProductsViewModel
            {
                CategoryHeaders = categoryHeaders,
                Products = products
            };

            return View(viewModel);
        }

        public IActionResult ProductDetails(int productId)
        {
            var product = _context.Product
                .Include(p => p.Category)
                .ThenInclude(c => c.CategoryHeader)
                .ThenInclude(ch => ch.MainCategory)
                .FirstOrDefault(p => p.ProductID == productId);

            if (product == null)
            {
                return NotFound();
            }

            var categoryHeaders = _context.CategoryHeader
                .Include(ch => ch.Categories)
                .ThenInclude(c => c.Products)
                .Where(ch => ch.MainCategory.Name == "Women")
                .ToList();

            ViewBag.ProductID = productId;
            ViewBag.CategoryHeaders = categoryHeaders;
            return View(product);
        }
    }
}