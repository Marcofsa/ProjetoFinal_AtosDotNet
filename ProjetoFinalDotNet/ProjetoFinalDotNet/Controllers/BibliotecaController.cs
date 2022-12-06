using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoFinalDotNet.Models;

namespace ProjetoFinalDotNet.Controllers
{
    public class BibliotecaController : Controller
    {
        private readonly Context _context;

        public BibliotecaController(Context context)
        {
            _context = context;
        }

        // GET: Biblioteca
        public async Task<IActionResult> Index()
        {
              return View(await _context.Biblioteca.ToListAsync());
        }

        // GET: Biblioteca/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Biblioteca == null)
            {
                return NotFound();
            }

            var biblioteca = await _context.Biblioteca
                .FirstOrDefaultAsync(m => m.Id == id);
            if (biblioteca == null)
            {
                return NotFound();
            }

            return View(biblioteca);
        }

        // GET: Biblioteca/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Biblioteca/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Plataforma,Categoria,Descrição")] Biblioteca biblioteca)
        {
            if (ModelState.IsValid)
            {
                _context.Add(biblioteca);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(biblioteca);
        }

        // GET: Biblioteca/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Biblioteca == null)
            {
                return NotFound();
            }

            var biblioteca = await _context.Biblioteca.FindAsync(id);
            if (biblioteca == null)
            {
                return NotFound();
            }
            return View(biblioteca);
        }

        // POST: Biblioteca/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Plataforma,Categoria,Descrição")] Biblioteca biblioteca)
        {
            if (id != biblioteca.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(biblioteca);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BibliotecaExists(biblioteca.Id))
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
            return View(biblioteca);
        }

        // GET: Biblioteca/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Biblioteca == null)
            {
                return NotFound();
            }

            var biblioteca = await _context.Biblioteca
                .FirstOrDefaultAsync(m => m.Id == id);
            if (biblioteca == null)
            {
                return NotFound();
            }

            return View(biblioteca);
        }

        // POST: Biblioteca/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Biblioteca == null)
            {
                return Problem("Entity set 'Context.Biblioteca'  is null.");
            }
            var biblioteca = await _context.Biblioteca.FindAsync(id);
            if (biblioteca != null)
            {
                _context.Biblioteca.Remove(biblioteca);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BibliotecaExists(int id)
        {
          return _context.Biblioteca.Any(e => e.Id == id);
        }
    }
}
