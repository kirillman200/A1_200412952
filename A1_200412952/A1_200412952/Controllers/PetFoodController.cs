using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using A1_200412952.Data;
using A1_200412952.Models;

namespace A1_200412952.Controllers
{
    public class PetFoodController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PetFoodController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PetFood
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pet_Food.ToListAsync());
        }

        // GET: PetFood/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet_Food = await _context.Pet_Food
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pet_Food == null)
            {
                return NotFound();
            }

            return View(pet_Food);
        }

        // GET: PetFood/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PetFood/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Price,Name,Description,Nutritional_Information,Weight,Brand,Type_Of_Animal")] Pet_Food pet_Food)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pet_Food);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pet_Food);
        }

        // GET: PetFood/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet_Food = await _context.Pet_Food.FindAsync(id);
            if (pet_Food == null)
            {
                return NotFound();
            }
            return View(pet_Food);
        }

        // POST: PetFood/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Price,Name,Description,Nutritional_Information,Weight,Brand,Type_Of_Animal")] Pet_Food pet_Food)
        {
            if (id != pet_Food.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pet_Food);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Pet_FoodExists(pet_Food.Id))
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
            return View(pet_Food);
        }

        // GET: PetFood/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet_Food = await _context.Pet_Food
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pet_Food == null)
            {
                return NotFound();
            }

            return View(pet_Food);
        }

        // POST: PetFood/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pet_Food = await _context.Pet_Food.FindAsync(id);
            _context.Pet_Food.Remove(pet_Food);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Pet_FoodExists(int id)
        {
            return _context.Pet_Food.Any(e => e.Id == id);
        }
    }
}
