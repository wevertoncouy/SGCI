using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SGCI.ApplicationCore.Entity;
using SGCI.Infrastructure.Data;

namespace SGCI.UI.Web.Controllers
{
    public class LancamentoController : Controller
    {
        private readonly GestaoCarteiraContext _context;

        public LancamentoController(GestaoCarteiraContext context)
        {
            _context = context;
        }

        // GET: Lancamento
        public async Task<IActionResult> Index()
        {
            var gestaoCarteiraContext = _context.Lancamentos.Include(l => l.Categoria).Include(l => l.Conta);
            return View(await gestaoCarteiraContext.ToListAsync());
        }

        // GET: Lancamento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lancamento = await _context.Lancamentos
                .Include(l => l.Categoria)
                .Include(l => l.Conta)
                .SingleOrDefaultAsync(m => m.LancamentoId == id);
            if (lancamento == null)
            {
                return NotFound();
            }

            return View(lancamento);
        }

        // GET: Lancamento/Create
        public IActionResult Create()
        {
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "Descriao");
            ViewData["ContaId"] = new SelectList(_context.Contas, "ContaId", "Nome");
            return View();
        }

        // POST: Lancamento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LancamentoId,DataLancamento,CategoriaId,ContaId,Valor,Descricao,StatusLancamento")] Lancamento lancamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lancamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "Descriao", lancamento.CategoriaId);
            ViewData["ContaId"] = new SelectList(_context.Contas, "ContaId", "Nome", lancamento.ContaId);
            return View(lancamento);
        }

        // GET: Lancamento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lancamento = await _context.Lancamentos.SingleOrDefaultAsync(m => m.LancamentoId == id);
            if (lancamento == null)
            {
                return NotFound();
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "Descriao", lancamento.CategoriaId);
            ViewData["ContaId"] = new SelectList(_context.Contas, "ContaId", "Nome", lancamento.ContaId);
            return View(lancamento);
        }

        // POST: Lancamento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LancamentoId,DataLancamento,CategoriaId,ContaId,Valor,Descricao,StatusLancamento")] Lancamento lancamento)
        {
            if (id != lancamento.LancamentoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lancamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LancamentoExists(lancamento.LancamentoId))
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
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "Descriao", lancamento.CategoriaId);
            ViewData["ContaId"] = new SelectList(_context.Contas, "ContaId", "Nome", lancamento.ContaId);
            return View(lancamento);
        }

        // GET: Lancamento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lancamento = await _context.Lancamentos
                .Include(l => l.Categoria)
                .Include(l => l.Conta)
                .SingleOrDefaultAsync(m => m.LancamentoId == id);
            if (lancamento == null)
            {
                return NotFound();
            }

            return View(lancamento);
        }

        // POST: Lancamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lancamento = await _context.Lancamentos.SingleOrDefaultAsync(m => m.LancamentoId == id);
            _context.Lancamentos.Remove(lancamento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LancamentoExists(int id)
        {
            return _context.Lancamentos.Any(e => e.LancamentoId == id);
        }
    }
}
