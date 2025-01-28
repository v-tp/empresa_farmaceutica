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
    public class UsuarioSistemaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsuarioSistemaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/UsuarioSistemas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuarioSistema>>> GetUsuarioSistema()
        {
            return await _context.UsuarioSistema.ToListAsync();
        }

        // GET: api/UsuarioSistemas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioSistema>> GetUsuarioSistema(int id)
        {
            var usuarioSistema = await _context.UsuarioSistema.FindAsync(id);

            if (usuarioSistema == null)
            {
                return NotFound();
            }

            return usuarioSistema;
        }

        // PUT: api/UsuarioSistemas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuarioSistema(int id, UsuarioSistema usuarioSistema)
        {
            if (id != usuarioSistema.Id)
            {
                return BadRequest();
            }

            _context.Entry(usuarioSistema).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioSistemaExists(id))
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

        // POST: api/UsuarioSistemas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UsuarioSistema>> PostUsuarioSistema(UsuarioSistema usuarioSistema)
        {
            _context.UsuarioSistema.Add(usuarioSistema);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsuarioSistema", new { id = usuarioSistema.Id }, usuarioSistema);
        }

        // DELETE: api/UsuarioSistemas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuarioSistema(int id)
        {
            var usuarioSistema = await _context.UsuarioSistema.FindAsync(id);
            if (usuarioSistema == null)
            {
                return NotFound();
            }

            _context.UsuarioSistema.Remove(usuarioSistema);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsuarioSistemaExists(int id)
        {
            return _context.UsuarioSistema.Any(e => e.Id == id);
        }
    }
}
