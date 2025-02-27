using FashionStore.Data;
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
            var mainCategories = _context.MainCategory.Include(mc => mc.CategoryHeaders).ThenInclude(ch => ch.Categories).Where(mc => mc.MainCategoryID == 1).ToList();
            return View(mainCategories);
        }

        public IActionResult Products(int categoryID)
        {
            var products = _context.Product.Where(p => p.CategoryID == categoryID).ToList();
            return View(products);
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