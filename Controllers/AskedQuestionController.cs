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
    public class AskedQuestionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AskedQuestionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AskedQuestion
        public async Task<IActionResult> Index()
        {
            return View(await _context.AskedQuestions.ToListAsync());
        }

        // GET: AskedQuestion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var askedQuestion = await _context.AskedQuestions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (askedQuestion == null)
            {
                return NotFound();
            }

            return View(askedQuestion);
        }

        // GET: AskedQuestion/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AskedQuestion/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Question,Answer")] AskedQuestion askedQuestion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(askedQuestion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(askedQuestion);
        }

        // GET: AskedQuestion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var askedQuestion = await _context.AskedQuestions.FindAsync(id);
            if (askedQuestion == null)
            {
                return NotFound();
            }
            return View(askedQuestion);
        }

        // POST: AskedQuestion/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Question,Answer")] AskedQuestion askedQuestion)
        {
            if (id != askedQuestion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(askedQuestion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AskedQuestionExists(askedQuestion.Id))
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
            return View(askedQuestion);
        }

        // GET: AskedQuestion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var askedQuestion = await _context.AskedQuestions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (askedQuestion == null)
            {
                return NotFound();
            }

            return View(askedQuestion);
        }

        // POST: AskedQuestion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var askedQuestion = await _context.AskedQuestions.FindAsync(id);
            if (askedQuestion != null)
            {
                _context.AskedQuestions.Remove(askedQuestion);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AskedQuestionExists(int id)
        {
            return _context.AskedQuestions.Any(e => e.Id == id);
        }
    }
}
