using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FashionStore.Models;

namespace FashionStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FashionStore.Models.Category> Category { get; set; } = default!;
        public DbSet<FashionStore.Models.CategoryHeader> CategoryHeader { get; set; } = default!;
        public DbSet<FashionStore.Models.MainCategory> MainCategory { get; set; } = default!;
        public DbSet<FashionStore.Models.Product> Product { get; set; } = default!;

        public DbSet<FashionStore.Models.Review> Review { get; set; } = default!;
    }
}
