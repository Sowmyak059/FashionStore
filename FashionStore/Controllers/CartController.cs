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
            var cartItem = await _context.CartItems.FirstOrDefaultAsync(c => c.UserId == userId && c.ProductID == request.ProductId);

            if (cartItem == null)
            {
                cartItem = new CartItem { UserId = userId, ProductID = request.ProductId, Quantity = 1 };
                _context.CartItems.Add(cartItem);
            }
            else
            {
                cartItem.Quantity += 1;
            }

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

        [HttpPost]
        public async Task<IActionResult> UpdateQuantity([FromBody] UpdateQuantityRequest request)
        {
            var userId = _userManager.GetUserId(User);
            var cartItem = await _context.CartItems.FirstOrDefaultAsync(c => c.CartItemID == request.CartItemId && c.UserId == userId);

            if (cartItem != null)
            {
                cartItem.Quantity = request.Quantity;
                await _context.SaveChangesAsync();
                return Ok();
            }
            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> GetTotalPrice()
        {
            var userId = _userManager.GetUserId(User);
            var cartItems = await _context.CartItems.Include(c => c.Product).Where(c => c.UserId == userId).ToListAsync();
            var totalPrice = cartItems.Sum(c => c.Product.Price * c.Quantity);
            return Json(totalPrice);
        }
        public IActionResult Checkout()
        {
            var paymentViewModel = new PaymentViewModel();
            return View(paymentViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> ProcessPayment(PaymentViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userId = _userManager.GetUserId(User);
                var cartItems = await _context.CartItems.Include(c => c.Product) .Where(c => c.UserId == userId) .ToListAsync();

                var order = new Order
                {
                    UserId = userId,
                    OrderDate = DateTime.Now,
                    TotalPrice = cartItems.Sum(c => c.Product.Price * c.Quantity),
                    OrderItems = cartItems.Select(c => new OrderItem
                    {
                        ProductID = c.ProductID,
                        Quantity = c.Quantity,
                        Price = c.Product.Price
                    }).ToList()
                };

                _context.Orders.Add(order);
                _context.CartItems.RemoveRange(cartItems);
                await _context.SaveChangesAsync();

                return RedirectToAction("PaymentSuccess");
            }

            TempData["ErrorMessage"] = "Invalid payment infromation. Please try again.";
            return View("Checkout", model);
        }

        public IActionResult PaymentSuccess()
        {
            return View();
        }
        public async Task<IActionResult> OrderHistory()
        {
            var userId = _userManager.GetUserId(User);
            var orders = await _context.Orders.Where(o => o.UserId == userId).ToListAsync();
            return View(orders);
        }

        public async Task<IActionResult> OrderDetails(int id)
        {
            var order = await _context.Orders.Include(o => o.OrderItems).ThenInclude(oi => oi.Product).FirstOrDefaultAsync(o => o.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }
    }

    public class AddToCartRequest
    {
        public int ProductId { get; set; }
    }
    public class UpdateQuantityRequest
    {
        public int CartItemId { get; set; }
        public int Quantity { get; set; }
    }
}