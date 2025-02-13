using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CompanyPortfolioo.Domain;

namespace CompanyPortfolioo.Controllers
{
    public class HorizontalSlidersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HorizontalSlidersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HorizontalSliders
        public async Task<IActionResult> Index()
        {
            return View(await _context.HorizontalSliders.ToListAsync());
        }

        // GET: HorizontalSliders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horizontalSlider = await _context.HorizontalSliders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (horizontalSlider == null)
            {
                return NotFound();
            }

            return View(horizontalSlider);
        }

        // GET: HorizontalSliders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HorizontalSliders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ImagePath")] HorizontalSlider horizontalSlider)
        {
            if (ModelState.IsValid)
            {
                _context.Add(horizontalSlider);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(horizontalSlider);
        }

        // GET: HorizontalSliders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horizontalSlider = await _context.HorizontalSliders.FindAsync(id);
            if (horizontalSlider == null)
            {
                return NotFound();
            }
            return View(horizontalSlider);
        }

        // POST: HorizontalSliders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ImagePath")] HorizontalSlider horizontalSlider)
        {
            if (id != horizontalSlider.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(horizontalSlider);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HorizontalSliderExists(horizontalSlider.Id))
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
            return View(horizontalSlider);
        }

        // GET: HorizontalSliders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horizontalSlider = await _context.HorizontalSliders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (horizontalSlider == null)
            {
                return NotFound();
            }

            return View(horizontalSlider);
        }

        // POST: HorizontalSliders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var horizontalSlider = await _context.HorizontalSliders.FindAsync(id);
            if (horizontalSlider != null)
            {
                _context.HorizontalSliders.Remove(horizontalSlider);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HorizontalSliderExists(int id)
        {
            return _context.HorizontalSliders.Any(e => e.Id == id);
        }
    }
}
