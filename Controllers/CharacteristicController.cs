using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace csharp_boolflix.Controllers
{
    public class CharacteristicController : Controller
    {
        NetflixContext context = new NetflixContext();

        // GET: Characteristic
        public ActionResult Index()
        {
              return View(context.Characteristics.ToList());
        }

        // GET: Characteristic/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || context.Characteristics == null)
            {
                return NotFound();
            }

            var characteristic = await context.Characteristics.FirstOrDefaultAsync(m => m.Id == id);
            if (characteristic == null)
            {
                return NotFound();
            }

            return View(characteristic);
        }

        // GET: Characteristic/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Characteristic/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Characteristic characteristic)
        {
            if (ModelState.IsValid)
            {
                context.Add(characteristic);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(characteristic);
        }

        // GET: Characteristic/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || context.Characteristics == null)
            {
                return NotFound();
            }

            var characteristic = await context.Characteristics.FindAsync(id);
            if (characteristic == null)
            {
                return NotFound();
            }
            return View(characteristic);
        }

        // POST: Characteristic/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("Id,Name")] Characteristic characteristic)
        {
            if (id != characteristic.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.Update(characteristic);
                    await context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CharacteristicExists(characteristic.Id))
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
            return View(characteristic);
        }

        // GET: Characteristic/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || context.Characteristics == null)
            {
                return NotFound();
            }

            var characteristic = await context.Characteristics
                .FirstOrDefaultAsync(m => m.Id == id);
            if (characteristic == null)
            {
                return NotFound();
            }

            return View(characteristic);
        }

        // POST: Characteristic/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (context.Characteristics == null)
            {
                return Problem("Entity set 'NetflixContext.Characteristics'  is null.");
            }
            var characteristic = await context.Characteristics.FindAsync(id);
            if (characteristic != null)
            {
                context.Characteristics.Remove(characteristic);
            }
            
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CharacteristicExists(int? id)
        {
          return context.Characteristics.Any(e => e.Id == id);
        }
    }
}
