using FashionStore.Data;
using FashionStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FashionStore.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReviewsController(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Review review)
        {
            //if (ModelState.IsValid)
            {
                review.ReviewDate = DateTime.Now;
                _context.Review.Add(review);
                await _context.SaveChangesAsync();
                return Ok();
            }
            //else
            //{
            //    // Log validation errors
            //    var errors = ModelState.Values.SelectMany(v => v.Errors);
            //    foreach (var error in errors)
            //    {
            //        Console.WriteLine(error.ErrorMessage);
            //    }
            //}
            //return BadRequest(ModelState);
        }

        public async Task<IActionResult> GetReviews(int productId)
        {
            var reviews = await _context.Review.Where(r => r.ProductID == productId).ToListAsync();
            return Ok(reviews);
        }
    }
}
