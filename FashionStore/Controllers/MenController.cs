using FashionStore.Data;
using FashionStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_CommerceStore.Controllers
{
    public class MenController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MenController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var menCategory = _context.MainCategory
                .Include(mc => mc.CategoryHeaders)
                .ThenInclude(ch => ch.Categories)
                .ThenInclude(c => c.Products)
                .FirstOrDefault(mc => mc.Name == "Men");

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
                .Where(ch => ch.MainCategory.Name == "Men")
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
                .Where(ch => ch.MainCategory.Name == "Men")
                .ToList();

            ViewBag.ProductID = productId;
            ViewBag.CategoryHeaders = categoryHeaders;
            return View(product);
        }

        [HttpPost]
        public IActionResult AddToCart([FromBody] int productId)
        {
            // Add logic to add the product to the cart
            // For example, add the product to a session or database
            return Ok();
        }

        [HttpPost]
        public IActionResult AddToWishlist([FromBody] int productId)
        {
            // Add logic to add the product to the wishlist
            // For example, add the product to a session or database
            return Ok();
        }

        public IActionResult Cart()
        {
            // Retrieve cart items from session or database
            return View();
        }

        public IActionResult Wishlist()
        {
            // Retrieve wishlist items from session or database
            return View();
        }
    }
}