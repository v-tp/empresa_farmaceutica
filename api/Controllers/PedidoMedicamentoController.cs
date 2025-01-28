using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiGestaoProdutos.Models;

namespace ApiGestaoProdutos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoMedicamentoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PedidoMedicamentoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/PedidoMedicamentoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PedidoMedicamento>>> GetPedidoMedicamento()
        {
            return await _context.PedidoMedicamento.ToListAsync();
        }

        // GET: api/PedidoMedicamentoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PedidoMedicamento>> GetPedidoMedicamento(int id)
        {
            var pedidoMedicamento = await _context.PedidoMedicamento.FindAsync(id);

            if (pedidoMedicamento == null)
            {
                return NotFound();
            }

            return pedidoMedicamento;
        }

        // PUT: api/PedidoMedicamentoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPedidoMedicamento(int id, PedidoMedicamento pedidoMedicamento)
        {
            if (id != pedidoMedicamento.Id)
            {
                return BadRequest();
            }

            _context.Entry(pedidoMedicamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PedidoMedicamentoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PedidoMedicamentoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PedidoMedicamento>> PostPedidoMedicamento(PedidoMedicamento pedidoMedicamento)
        {
            _context.PedidoMedicamento.Add(pedidoMedicamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPedidoMedicamento", new { id = pedidoMedicamento.Id }, pedidoMedicamento);
        }

        // DELETE: api/PedidoMedicamentoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePedidoMedicamento(int id)
        {
            var pedidoMedicamento = await _context.PedidoMedicamento.FindAsync(id);
            if (pedidoMedicamento == null)
            {
                return NotFound();
            }

            _context.PedidoMedicamento.Remove(pedidoMedicamento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PedidoMedicamentoExists(int id)
        {
            return _context.PedidoMedicamento.Any(e => e.Id == id);
        }
    }
}
