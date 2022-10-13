using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WuzzyBears.Data;
using WuzzyBears.Models;

namespace WuzzyBears.Controllers
{
    public class WuzzyBearsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WuzzyBearsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WuzzyBears
        /*public async Task<IActionResult> Index(string searchString)
        {
            //return View(await _context.WuzzyBear.ToListAsync());
            var Bears = from m in _context.WuzzyBear
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                Bears = Bears.Where(s => s.TypeOfTeddy.Contains(searchString));
            }

            return View(await Bears.ToListAsync());
        }*/

        // GET: WuzzyBears
        public async Task<IActionResult> Index(string TeddyMaterial, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> materialQuery = from m in _context.WuzzyBear
                                            orderby m.MaterialOfTeddy
                                            select m.MaterialOfTeddy;

            var TeddyBears = from m in _context.WuzzyBear
                         select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                TeddyBears = TeddyBears.Where(s => s.MaterialOfTeddy.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(TeddyMaterial))
            {
                TeddyBears = TeddyBears.Where(x => x.MaterialOfTeddy == TeddyMaterial);
            }

            var wuzzyBearMaterialVM = new WuzzyBearMaterialViewModel
            {
                Materials = new SelectList(await materialQuery.Distinct().ToListAsync()),
                WuzzyBears = await TeddyBears.ToListAsync()
            };

            return View(wuzzyBearMaterialVM);
        }

        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }

        // GET: WuzzyBears/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wuzzyBear = await _context.WuzzyBear
                .FirstOrDefaultAsync(m => m.Id == id);
            if (wuzzyBear == null)
            {
                return NotFound();
            }

            return View(wuzzyBear);
        }

        // GET: WuzzyBears/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WuzzyBears/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TeddySerialNumber,TypeOfTeddy,MaterialOfTeddy,Manufactured,SizeOfTeddy,CostOfTeddy")] WuzzyBear wuzzyBear)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wuzzyBear);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(wuzzyBear);
        }

        // GET: WuzzyBears/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wuzzyBear = await _context.WuzzyBear.FindAsync(id);
            if (wuzzyBear == null)
            {
                return NotFound();
            }
            return View(wuzzyBear);
        }

        // POST: WuzzyBears/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TeddySerialNumber,TypeOfTeddy,MaterialOfTeddy,Manufactured,SizeOfTeddy,CostOfTeddy")] WuzzyBear wuzzyBear)
        {
            if (id != wuzzyBear.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wuzzyBear);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WuzzyBearExists(wuzzyBear.Id))
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
            return View(wuzzyBear);
        }

        // GET: WuzzyBears/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wuzzyBear = await _context.WuzzyBear
                .FirstOrDefaultAsync(m => m.Id == id);
            if (wuzzyBear == null)
            {
                return NotFound();
            }

            return View(wuzzyBear);
        }

        // POST: WuzzyBears/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wuzzyBear = await _context.WuzzyBear.FindAsync(id);
            _context.WuzzyBear.Remove(wuzzyBear);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WuzzyBearExists(int id)
        {
            return _context.WuzzyBear.Any(e => e.Id == id);
        }
    }
}
