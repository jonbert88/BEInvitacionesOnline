using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BEInvitacionesOnline.Data;
using BEInvitacionesOnline.Models;

namespace BEInvitacionesOnline.Controllers
{
    public class TypesTemplatesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TypesTemplatesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TypesTemplates
        public async Task<IActionResult> Index()
        {
              return _context.TypeTemplates != null ? 
                          View(await _context.TypeTemplates.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.TypeTemplates'  is null.");
        }

        // GET: TypesTemplates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TypeTemplates == null)
            {
                return NotFound();
            }

            var typesTemplate = await _context.TypeTemplates
                .FirstOrDefaultAsync(m => m.id == id);
            if (typesTemplate == null)
            {
                return NotFound();
            }

            return View(typesTemplate);
        }

        // GET: TypesTemplates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TypesTemplates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,typeTemp")] TypesTemplate typesTemplate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(typesTemplate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typesTemplate);
        }

        // GET: TypesTemplates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TypeTemplates == null)
            {
                return NotFound();
            }

            var typesTemplate = await _context.TypeTemplates.FindAsync(id);
            if (typesTemplate == null)
            {
                return NotFound();
            }
            return View(typesTemplate);
        }

        // POST: TypesTemplates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,typeTemp")] TypesTemplate typesTemplate)
        {
            if (id != typesTemplate.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typesTemplate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypesTemplateExists(typesTemplate.id))
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
            return View(typesTemplate);
        }

        // GET: TypesTemplates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TypeTemplates == null)
            {
                return NotFound();
            }

            var typesTemplate = await _context.TypeTemplates
                .FirstOrDefaultAsync(m => m.id == id);
            if (typesTemplate == null)
            {
                return NotFound();
            }

            return View(typesTemplate);
        }

        // POST: TypesTemplates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TypeTemplates == null)
            {
                return Problem("Entity set 'ApplicationDbContext.TypeTemplates'  is null.");
            }
            var typesTemplate = await _context.TypeTemplates.FindAsync(id);
            if (typesTemplate != null)
            {
                _context.TypeTemplates.Remove(typesTemplate);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypesTemplateExists(int id)
        {
          return (_context.TypeTemplates?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
