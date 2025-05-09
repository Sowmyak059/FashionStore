﻿using FashionStore.Data;
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
    
    public class KidsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KidsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var menCategory = _context.MainCategory
                .Include(mc => mc.CategoryHeaders)
                .ThenInclude(ch => ch.Categories)
                .ThenInclude(c => c.Products)
                .FirstOrDefault(mc => mc.Name == "Kids");

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
                .Where(ch => ch.MainCategory.Name == "Kids")
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
                .Include(p => p.Reviews)
                .FirstOrDefault(p => p.ProductID == productId);

            if (product == null)
            {
                return NotFound();
            }

            var categoryHeaders = _context.CategoryHeader
                .Include(ch => ch.Categories)
                .ThenInclude(c => c.Products)
                .Where(ch => ch.MainCategory.Name == "Kids")
                .ToList();

            ViewBag.ProductID = productId;
            ViewBag.CategoryHeaders = categoryHeaders;
            return View(product);
        }
    }
}