using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FashionStore.Data;
using FashionStore.Models;
using Microsoft.AspNetCore.Authorization;

namespace FashionStore.Controllers
{
    public class MainCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MainCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MainCategories
        [Authorize(Roles = "Admins,Owners")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.MainCategory.ToListAsync());
        }

        // GET: MainCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MainCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admins")]
        public async Task<IActionResult> Create([Bind("MainCategoryID,Name")] MainCategory mainCategory)
        {
            //if (ModelState.IsValid)
            {
                _context.Add(mainCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
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
            //return View(mainCategory);
        }

        // GET: MainCategories/Edit/5]

        [Authorize(Roles = "Admins")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mainCategory = await _context.MainCategory.FindAsync(id);
            if (mainCategory == null)
            {
                return NotFound();
            }
            return View(mainCategory);
        }

        // POST: MainCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admins")]
        public async Task<IActionResult> Edit(int id, [Bind("MainCategoryID,Name")] MainCategory mainCategory)
        {
            if (id != mainCategory.MainCategoryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mainCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MainCategoryExists(mainCategory.MainCategoryID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(mainCategory);
        }

        // GET: MainCategories/Delete/5]
        [Authorize(Roles = "Admins")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mainCategory = await _context.MainCategory
                .FirstOrDefaultAsync(m => m.MainCategoryID == id);
            if (mainCategory == null)
            {
                return NotFound();
            }

            return View(mainCategory);
        }

        // POST: MainCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admins")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mainCategory = await _context.MainCategory.FindAsync(id);
            if (mainCategory != null)
            {
                _context.MainCategory.Remove(mainCategory);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MainCategoryExists(int id)
        {
            return _context.MainCategory.Any(e => e.MainCategoryID == id);
        }
    }
}
