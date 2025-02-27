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
    [Authorize(Roles = "Admins")]
    public class CategoryHeadersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryHeadersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CategoryHeaders
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CategoryHeader.Include(c => c.MainCategory);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CategoryHeaders/Create
        public IActionResult Create()
        {
            ViewData["MainCategoryID"] = new SelectList(_context.Set<MainCategory>(), "MainCategoryID", "MainCategoryID");
            return View();
        }

        // POST: CategoryHeaders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryHeaderID,MainCategoryID,Name")] CategoryHeader categoryHeader)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoryHeader);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MainCategoryID"] = new SelectList(_context.Set<MainCategory>(), "MainCategoryID", "MainCategoryID", categoryHeader.MainCategoryID);
            return View(categoryHeader);
        }

        // GET: CategoryHeaders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryHeader = await _context.CategoryHeader.FindAsync(id);
            if (categoryHeader == null)
            {
                return NotFound();
            }
            ViewData["MainCategoryID"] = new SelectList(_context.Set<MainCategory>(), "MainCategoryID", "MainCategoryID", categoryHeader.MainCategoryID);
            return View(categoryHeader);
        }

        // POST: CategoryHeaders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoryHeaderID,MainCategoryID,Name")] CategoryHeader categoryHeader)
        {
            if (id != categoryHeader.CategoryHeaderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categoryHeader);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryHeaderExists(categoryHeader.CategoryHeaderID))
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
            ViewData["MainCategoryID"] = new SelectList(_context.Set<MainCategory>(), "MainCategoryID", "MainCategoryID", categoryHeader.MainCategoryID);
            return View(categoryHeader);
        }

        // GET: CategoryHeaders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryHeader = await _context.CategoryHeader
                .Include(c => c.MainCategory)
                .FirstOrDefaultAsync(m => m.CategoryHeaderID == id);
            if (categoryHeader == null)
            {
                return NotFound();
            }

            return View(categoryHeader);
        }

        // POST: CategoryHeaders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categoryHeader = await _context.CategoryHeader.FindAsync(id);
            if (categoryHeader != null)
            {
                _context.CategoryHeader.Remove(categoryHeader);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryHeaderExists(int id)
        {
            return _context.CategoryHeader.Any(e => e.CategoryHeaderID == id);
        }
    }
}
