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
    public class MateriaPrimaMedicamentoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MateriaPrimaMedicamentoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/MateriaPrimaMedicamento
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MateriaPrimaMedicamento>>> GetMateriaPrimaMedicamento()
        {
            return await _context.MateriaPrimaMedicamento.ToListAsync();
        }

        // GET: api/MateriaPrimaMedicamento/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MateriaPrimaMedicamento>> GetMateriaPrimaMedicamento(int id)
        {
            var materiaPrimaMedicamento = await _context.MateriaPrimaMedicamento.FindAsync(id);

            if (materiaPrimaMedicamento == null)
            {
                return NotFound();
            }

            return materiaPrimaMedicamento;
        }

        // PUT: api/MateriaPrimaMedicamento/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMateriaPrimaMedicamento(int id, MateriaPrimaMedicamento materiaPrimaMedicamento)
        {
            if (id != materiaPrimaMedicamento.Id)
            {
                return BadRequest();
            }

            _context.Entry(materiaPrimaMedicamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MateriaPrimaMedicamentoExists(id))
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

        // POST: api/MateriaPrimaMedicamento
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MateriaPrimaMedicamento>> PostMateriaPrimaMedicamento(MateriaPrimaMedicamento materiaPrimaMedicamento)
        {
            _context.MateriaPrimaMedicamento.Add(materiaPrimaMedicamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMateriaPrimaMedicamento", new { id = materiaPrimaMedicamento.Id }, materiaPrimaMedicamento);
        }

        // DELETE: api/MateriaPrimaMedicamento/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMateriaPrimaMedicamento(int id)
        {
            var materiaPrimaMedicamento = await _context.MateriaPrimaMedicamento.FindAsync(id);
            if (materiaPrimaMedicamento == null)
            {
                return NotFound();
            }

            _context.MateriaPrimaMedicamento.Remove(materiaPrimaMedicamento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MateriaPrimaMedicamentoExists(int id)
        {
            return _context.MateriaPrimaMedicamento.Any(e => e.Id == id);
        }
    }
}
