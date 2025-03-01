using FashionStore.Data;
using FashionStore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FashionStore.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public CartController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart([FromBody] AddToCartRequest request)
        {
            var userId = _userManager.GetUserId(User);
            var cartItem = new CartItem { UserId = userId, ProductID = request.ProductId };
            _context.CartItems.Add(cartItem);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AddToWishlist([FromBody] AddToCartRequest request)
        {
            var userId = _userManager.GetUserId(User);
            var wishlistItem = new WishlistItem { UserId = userId, ProductID = request.ProductId };
            _context.WishlistItems.Add(wishlistItem);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteFromCart(int id)
        {
            var userId = _userManager.GetUserId(User);
            var cartItem = await _context.CartItems.FirstOrDefaultAsync(c => c.CartItemID == id && c.UserId == userId);
            if (cartItem != null)
            {
                _context.CartItems.Remove(cartItem);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return NotFound();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteFromWishlist(int id)
        {
            var userId = _userManager.GetUserId(User);
            var wishlistItem = await _context.WishlistItems.FirstOrDefaultAsync(w => w.WishlistItemID == id && w.UserId == userId);
            if (wishlistItem != null)
            {
                _context.WishlistItems.Remove(wishlistItem);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return NotFound();
        }

        public async Task<IActionResult> Cart()
        {
            var userId = _userManager.GetUserId(User);
            var cartItems = await _context.CartItems.Include(c => c.Product).Where(c => c.UserId == userId).ToListAsync();
            return View(cartItems);
        }

        public async Task<IActionResult> Wishlist()
        {
            var userId = _userManager.GetUserId(User);
            var wishlistItems = await _context.WishlistItems.Include(w => w.Product).Where(w => w.UserId == userId).ToListAsync();
            return View(wishlistItems);
        }
    }

    public class AddToCartRequest
    {
        public int ProductId { get; set; }
    }
}