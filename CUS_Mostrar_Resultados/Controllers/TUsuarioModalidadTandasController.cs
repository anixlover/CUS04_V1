using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CUS_Mostrar_Resultados.Models;

namespace CUS_Mostrar_Resultados.Controllers
{
    public class TUsuarioModalidadTandasController : Controller
    {
        private readonly DB_A4F05E_SGIAMTPContext _context;

        public TUsuarioModalidadTandasController(DB_A4F05E_SGIAMTPContext context)
        {
            _context = context;
        }

        // GET: TUsuarioModalidadTandas
        public async Task<IActionResult> Index()
        {
            var dB_A4F05E_SGIAMTPContext = _context.TUsuarioModalidadTanda
                .Include(t => t.FkIumtCodPartNavigation)
                .Include(t => t.FkIumtCodTanNavigation);

            return View(await dB_A4F05E_SGIAMTPContext.ToListAsync());
        }

        // GET: TUsuarioModalidadTandas/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tUsuarioModalidadTanda = await _context.TUsuarioModalidadTanda
                .Include(t => t.FkIumtCodPartNavigation)
                .Include(t => t.FkIumtCodTanNavigation)
                .FirstOrDefaultAsync(m => m.PkVumtCod == id);

            if (tUsuarioModalidadTanda == null)
            {
                return NotFound();
            }

            return View(tUsuarioModalidadTanda);
        }

        // GET: TUsuarioModalidadTandas/Create
        public IActionResult Create()
        {
            ViewData["FkIumtCodPart"] = new SelectList(_context.TUsuarioModalidad, "PkIumCodUm", "FkIuDni");
            ViewData["FkIumtCodTan"] = new SelectList(_context.TTanda, "PkItCodTan", "VtDescripcion");
            return View();
        }

        // POST: TUsuarioModalidadTandas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkVumtCod,FkIumtCodPart,FkIumtCodTan,IumtPuntajeTotal,IumtPista,IumtEstado")] TUsuarioModalidadTanda tUsuarioModalidadTanda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tUsuarioModalidadTanda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FkIumtCodPart"] = new SelectList(_context.TUsuarioModalidad, "PkIumCodUm", "VmUmArchivoB", tUsuarioModalidadTanda.FkIumtCodPart);
            ViewData["FkIumtCodTan"] = new SelectList(_context.TTanda, "PkItCodTan", "VtDescripcion", tUsuarioModalidadTanda.FkIumtCodTan);
            return View(tUsuarioModalidadTanda);
        }

        // GET: TUsuarioModalidadTandas/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tUsuarioModalidadTanda = await _context.TUsuarioModalidadTanda.FindAsync(id);
            if (tUsuarioModalidadTanda == null)
            {
                return NotFound();
            }
            ViewData["FkIumtCodPart"] = new SelectList(_context.TUsuarioModalidad, "PkIumCodUm", "VmUmArchivoB", tUsuarioModalidadTanda.FkIumtCodPart);
            ViewData["FkIumtCodTan"] = new SelectList(_context.TTanda, "PkItCodTan", "VtDescripcion", tUsuarioModalidadTanda.FkIumtCodTan);
            return View(tUsuarioModalidadTanda);
        }

        // POST: TUsuarioModalidadTandas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PkVumtCod,FkIumtCodPart,FkIumtCodTan,IumtPuntajeTotal,IumtPista,IumtEstado")] TUsuarioModalidadTanda tUsuarioModalidadTanda)
        {
            if (id != tUsuarioModalidadTanda.PkVumtCod)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tUsuarioModalidadTanda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TUsuarioModalidadTandaExists(tUsuarioModalidadTanda.PkVumtCod))
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
            ViewData["FkIumtCodPart"] = new SelectList(_context.TUsuarioModalidad, "PkIumCodUm", "VmUmArchivoB", tUsuarioModalidadTanda.FkIumtCodPart);
            ViewData["FkIumtCodTan"] = new SelectList(_context.TTanda, "PkItCodTan", "VtDescripcion", tUsuarioModalidadTanda.FkIumtCodTan);
            return View(tUsuarioModalidadTanda);
        }

        // GET: TUsuarioModalidadTandas/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tUsuarioModalidadTanda = await _context.TUsuarioModalidadTanda
                .Include(t => t.FkIumtCodPartNavigation)
                .Include(t => t.FkIumtCodTanNavigation)
                .FirstOrDefaultAsync(m => m.PkVumtCod == id);
            if (tUsuarioModalidadTanda == null)
            {
                return NotFound();
            }

            return View(tUsuarioModalidadTanda);
        }

        // POST: TUsuarioModalidadTandas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tUsuarioModalidadTanda = await _context.TUsuarioModalidadTanda.FindAsync(id);
            _context.TUsuarioModalidadTanda.Remove(tUsuarioModalidadTanda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TUsuarioModalidadTandaExists(string id)
        {
            return _context.TUsuarioModalidadTanda.Any(e => e.PkVumtCod == id);
        }
    }
}
