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
    public class TemplatesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TemplatesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Templates
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Templates.Include(t => t.TypeTemplate);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Templates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Templates == null)
            {
                return NotFound();
            }

            var template = await _context.Templates
                .Include(t => t.TypeTemplate)
                .FirstOrDefaultAsync(m => m.id == id);
            if (template == null)
            {
                return NotFound();
            }

            return View(template);
        }

        // GET: Templates/Create
        public IActionResult Create()
        {
            ViewData["idTypeTemplate"] = new SelectList(_context.TypeTemplates, "id", "typeTemp");
            return View();
        }

        // POST: Templates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,idTypeTemplate,nombrePlantilla,divHeader,divContentCero,divContentOne,divContentTwo,divContentThree,divContentFour,divContentFive,divContentSix,divContentSeven,divContentEight,divContentFooter")] Template template)
        {
            if (ModelState.IsValid)
            {
                _context.Add(template);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idTypeTemplate"] = new SelectList(_context.TypeTemplates, "id", "typeTemp", template.idTypeTemplate);
            return View(template);
        }

        // GET: Templates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Templates == null)
            {
                return NotFound();
            }

            var template = await _context.Templates.FindAsync(id);
            if (template == null)
            {
                return NotFound();
            }
            ViewData["idTypeTemplate"] = new SelectList(_context.TypeTemplates, "id", "typeTemp", template.idTypeTemplate);
            return View(template);
        }

        // POST: Templates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,idTypeTemplate,nombrePlantilla,divHeader,divContentCero,divContentOne,divContentTwo,divContentThree,divContentFour,divContentFive,divContentSix,divContentSeven,divContentEight,divContentFooter")] Template template)
        {
            if (id != template.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(template);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TemplateExists(template.id))
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
            ViewData["idTypeTemplate"] = new SelectList(_context.TypeTemplates, "id", "typeTemp", template.idTypeTemplate);
            return View(template);
        }

        // GET: Templates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Templates == null)
            {
                return NotFound();
            }

            var template = await _context.Templates
                .Include(t => t.TypeTemplate)
                .FirstOrDefaultAsync(m => m.id == id);
            if (template == null)
            {
                return NotFound();
            }

            return View(template);
        }

        // POST: Templates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Templates == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Templates'  is null.");
            }
            var template = await _context.Templates.FindAsync(id);
            if (template != null)
            {
                _context.Templates.Remove(template);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TemplateExists(int id)
        {
          return (_context.Templates?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
