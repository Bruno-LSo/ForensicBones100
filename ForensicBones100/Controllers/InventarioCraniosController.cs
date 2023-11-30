using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ForensicBones100.Models;

namespace ForensicBones100.Controllers
{
    public class InventarioCraniosController : Controller
    {
        private readonly AppDbContext _context;

        public InventarioCraniosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: InventarioCranios
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.InventarioCranio.Include(i => i.InventarioEsqueleto);
            return View(await appDbContext.ToListAsync());
        }

        // GET: InventarioCranios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventarioCranio = await _context.InventarioCranio
                .Include(i => i.InventarioEsqueleto)
                .FirstOrDefaultAsync(m => m.InventarioCranioId == id);
            if (inventarioCranio == null)
            {
                return NotFound();
            }

            return View(inventarioCranio);
        }

        // GET: InventarioCranios/Create
        public IActionResult Create()
        {
            ViewData["InventarioEsqueletoId"] = new SelectList(_context.InventariosEsqueleto, "InventarioEsqueletoId", "InventarioEsqueletoId");
            return View();
        }

        // POST: InventarioCranios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InventarioCranioId,InventarioEsqueletoId,Frontal,FrontalDesc,Ocipital,OcipitalDesc,Esfenoide,EsfenoideDesc,Maxilar,MaxilarDesc,Vomer,VomerDesc,ParietalEsquerdo,ParietalEsquerdoDesc,TemporalEsquerdo,TemporalEsquerdoDesc,ConchaNasalInferiorEsquerda,ConchaNasalInferiorEsquerdaDesc,Etmoide,EtmoideDesc,LacrimalEsquerdo,LacrimalEsquerdoDesc,NasalEsquerdo,NasalEsquerdoDesc,ZigomaticoEsquerdo,ZigomaticoEsquerdoDesc,ParietalDireito,ParietalDireitoDesc,TemporalDireito,TemporalDireitoDesc,ConchaNasalInferiorDireita,ConchaNasalInferiorDireitaDesc,LacrimalDireito,LacrimalDireitoDesc,NasalDireito,NasalDireitoDesc,ZigomaticoDireito,ZigomaticoDireitoDesc,Hioide,HioideDesc,CartilagemTireoide,CartilagemTireoideDesc,Mandibula,MandibulaDesc,Observacoes,FotosCranio")] InventarioCranio inventarioCranio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inventarioCranio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InventarioEsqueletoId"] = new SelectList(_context.InventariosEsqueleto, "InventarioEsqueletoId", "InventarioEsqueletoId", inventarioCranio.InventarioEsqueletoId);
            return View(inventarioCranio);
        }

        // GET: InventarioCranios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventarioCranio = await _context.InventarioCranio.FindAsync(id);
            if (inventarioCranio == null)
            {
                return NotFound();
            }
            ViewData["InventarioEsqueletoId"] = new SelectList(_context.InventariosEsqueleto, "InventarioEsqueletoId", "InventarioEsqueletoId", inventarioCranio.InventarioEsqueletoId);
            return View(inventarioCranio);
        }

        // POST: InventarioCranios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InventarioCranioId,InventarioEsqueletoId,Frontal,FrontalDesc,Ocipital,OcipitalDesc,Esfenoide,EsfenoideDesc,Maxilar,MaxilarDesc,Vomer,VomerDesc,ParietalEsquerdo,ParietalEsquerdoDesc,TemporalEsquerdo,TemporalEsquerdoDesc,ConchaNasalInferiorEsquerda,ConchaNasalInferiorEsquerdaDesc,Etmoide,EtmoideDesc,LacrimalEsquerdo,LacrimalEsquerdoDesc,NasalEsquerdo,NasalEsquerdoDesc,ZigomaticoEsquerdo,ZigomaticoEsquerdoDesc,ParietalDireito,ParietalDireitoDesc,TemporalDireito,TemporalDireitoDesc,ConchaNasalInferiorDireita,ConchaNasalInferiorDireitaDesc,LacrimalDireito,LacrimalDireitoDesc,NasalDireito,NasalDireitoDesc,ZigomaticoDireito,ZigomaticoDireitoDesc,Hioide,HioideDesc,CartilagemTireoide,CartilagemTireoideDesc,Mandibula,MandibulaDesc,Observacoes,FotosCranio")] InventarioCranio inventarioCranio)
        {
            if (id != inventarioCranio.InventarioCranioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inventarioCranio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventarioCranioExists(inventarioCranio.InventarioCranioId))
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
            ViewData["InventarioEsqueletoId"] = new SelectList(_context.InventariosEsqueleto, "InventarioEsqueletoId", "InventarioEsqueletoId", inventarioCranio.InventarioEsqueletoId);
            return View(inventarioCranio);
        }

        // GET: InventarioCranios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventarioCranio = await _context.InventarioCranio
                .Include(i => i.InventarioEsqueleto)
                .FirstOrDefaultAsync(m => m.InventarioCranioId == id);
            if (inventarioCranio == null)
            {
                return NotFound();
            }

            return View(inventarioCranio);
        }

        // POST: InventarioCranios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inventarioCranio = await _context.InventarioCranio.FindAsync(id);
            if (inventarioCranio != null)
            {
                _context.InventarioCranio.Remove(inventarioCranio);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InventarioCranioExists(int id)
        {
            return _context.InventarioCranio.Any(e => e.InventarioCranioId == id);
        }
    }
}
