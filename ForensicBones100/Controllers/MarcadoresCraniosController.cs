﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ForensicBones100.Models;
using Microsoft.AspNetCore.Authorization;

namespace ForensicBones100.Controllers
{
    [Authorize]
    public class MarcadoresCraniosController : Controller
    {
        private readonly AppDbContext _context;

        public MarcadoresCraniosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: MarcadoresCranios
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.MarcadoresCranios.Include(m => m.Relatorio);
            return View(await appDbContext.ToListAsync());
        }

        // GET: MarcadoresCranios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marcadoresCranio = await _context.MarcadoresCranios
                .Include(m => m.Relatorio)
                .FirstOrDefaultAsync(m => m.MarcadoresCranioId == id);
            if (marcadoresCranio == null)
            {
                return NotFound();
            }

            return View(marcadoresCranio);
        }

        // GET: MarcadoresCranios/Create
        public IActionResult Create()
        {
            ViewData["RelatorioMarcadoresId"] = new SelectList(_context.Relatorios, "RelatorioId", "Codigo");
            return View();
        }

        // POST: MarcadoresCranios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MarcadoresCranioId,RelatorioMarcadoresId,CristaNucal,ProcessoMastoide,EminenciaMentoniana,SupraOrbital,AreaGlabela,CalculoEstimativaSexo,Observacoes")] MarcadoresCranio marcadoresCranio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marcadoresCranio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RelatorioMarcadoresId"] = new SelectList(_context.Relatorios, "RelatorioId", "Codigo", marcadoresCranio.RelatorioMarcadoresId);
            return View(marcadoresCranio);
        }

        // GET: MarcadoresCranios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marcadoresCranio = await _context.MarcadoresCranios.FindAsync(id);
            if (marcadoresCranio == null)
            {
                return NotFound();
            }
            ViewData["RelatorioMarcadoresId"] = new SelectList(_context.Relatorios, "RelatorioId", "Codigo", marcadoresCranio.RelatorioMarcadoresId);
            return View(marcadoresCranio);
        }

        // POST: MarcadoresCranios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MarcadoresCranioId,RelatorioMarcadoresId,CristaNucal,ProcessoMastoide,EminenciaMentoniana,SupraOrbital,AreaGlabela,CalculoEstimativaSexo,Observacoes")] MarcadoresCranio marcadoresCranio)
        {
            if (id != marcadoresCranio.MarcadoresCranioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(marcadoresCranio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MarcadoresCranioExists(marcadoresCranio.MarcadoresCranioId))
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
            ViewData["RelatorioMarcadoresId"] = new SelectList(_context.Relatorios, "RelatorioId", "Codigo", marcadoresCranio.RelatorioMarcadoresId);
            return View(marcadoresCranio);
        }

        // GET: MarcadoresCranios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marcadoresCranio = await _context.MarcadoresCranios
                .Include(m => m.Relatorio)
                .FirstOrDefaultAsync(m => m.MarcadoresCranioId == id);
            if (marcadoresCranio == null)
            {
                return NotFound();
            }

            return View(marcadoresCranio);
        }

        // POST: MarcadoresCranios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var marcadoresCranio = await _context.MarcadoresCranios.FindAsync(id);
            if (marcadoresCranio != null)
            {
                _context.MarcadoresCranios.Remove(marcadoresCranio);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MarcadoresCranioExists(int id)
        {
            return _context.MarcadoresCranios.Any(e => e.MarcadoresCranioId == id);
        }

        public string EstimarSexo(MarcadoresCranio marcadoresCranio)
        {
            try
            {
                var valores = new char[]
                {
            marcadoresCranio.CristaNucal,
            marcadoresCranio.ProcessoMastoide,
            marcadoresCranio.EminenciaMentoniana,
            marcadoresCranio.AreaGlabela,
            marcadoresCranio.SupraOrbital
                };

                var valorMaisFrequente = valores
                    .GroupBy(i => i)
                    .OrderByDescending(g => g.Count())
                    .Select(g => g.Key)
                    .FirstOrDefault();

                string resultado;

                switch (valorMaisFrequente)
                {
                    case 'F':
                        resultado = "Feminino";
                        break;
                    case 'M':
                        resultado = "Masculino";
                        break;
                    case 'I':
                        resultado = "Inconclusivo";
                        break;
                    default:
                        resultado = "Inconclusivo";
                        break;
                }

                marcadoresCranio.CalculoEstimativaSexo = resultado;

                return resultado;
            }
            catch
            {
                return "Erro ao estimar o sexo";
            }
        }


    }
}

