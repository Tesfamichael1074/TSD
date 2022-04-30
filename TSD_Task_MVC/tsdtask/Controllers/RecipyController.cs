#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tsdtask.Models;

namespace tsdtask.Controllers
{
    public class RecipyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RecipyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Recipy
        public async Task<IActionResult> Index([Bind("Search,DetailsToView")] HomePageFilter homefilter)
        {   
            // HomePageFilter homefilter = new HomePageFilter();
            // homefilter.Search = name;

            if(homefilter.Search != null)
            {

                var recipies = await _context.Recipy
                    .Where(s => s.Name!.Contains(homefilter.Search)).ToListAsync();
                homefilter.Recipies = recipies;

            } else {
                var recipies = await _context.Recipy.ToListAsync();
                homefilter.Recipies = recipies;
            }

            if(homefilter.DetailsToView != null) {
                Recipy recipy = await _context.Recipy
                    .FirstOrDefaultAsync(m => m.Id == int.Parse(homefilter.DetailsToView));
                homefilter.Details = recipy;
            }

            
            return View(homefilter);
        }

        // GET: Recipy/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipy = await _context.Recipy
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recipy == null)
            {
                return NotFound();
            }

            return View(recipy);
        }

        // GET: Recipy/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Recipy/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NumOfLikes,Time,Name,Difficulty,Ingredients,Process,TipsAndTricks")] Recipy recipy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recipy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(recipy);
        }

        // GET: Recipy/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipy = await _context.Recipy.FindAsync(id);
            if (recipy == null)
            {
                return NotFound();
            }
            return View(recipy);
        }

        // POST: Recipy/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NumOfLikes,Time,Name,Difficulty,Ingredients,Process,TipsAndTricks")] Recipy recipy)
        {
            if (id != recipy.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recipy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecipyExists(recipy.Id))
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
            return View(recipy);
        }

        // GET: Recipy/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipy = await _context.Recipy
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recipy == null)
            {
                return NotFound();
            }

            return View(recipy);
        }

        // POST: Recipy/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recipy = await _context.Recipy.FindAsync(id);
            _context.Recipy.Remove(recipy);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecipyExists(int id)
        {
            return _context.Recipy.Any(e => e.Id == id);
        }
    }
}
