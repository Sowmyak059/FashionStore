using FashionStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FashionStore.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder); // Ensure Identity is properly configured
        }

        public DbSet<Category> Category { get; set; } = default!;
        public DbSet<CategoryHeader> CategoryHeader { get; set; } = default!;
        public DbSet<MainCategory> MainCategory { get; set; } = default!;
        public DbSet<Product> Product { get; set; } = default!;
        public DbSet<Review> Review { get; set; } = default!;
        public DbSet<CartItem> CartItems { get; set; } = default!;
        public DbSet<WishlistItem> WishlistItems { get; set; } = default!;
        public DbSet<Offer> Offers { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<OrderItem> OrderItems { get; set; } = default!;
    }
}