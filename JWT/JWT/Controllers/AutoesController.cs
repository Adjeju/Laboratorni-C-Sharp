using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JWT.Models;

namespace JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoesController : Controller
    {
        private readonly AutoDBContext _context;

        public AutoesController(AutoDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Auto>>> GetAutoes()
        {
            return await _context.Auto.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Auto>> GetAutoes(int id)
        {
            var autoes = await _context.Auto.FindAsync(id);

            if (autoes == null)
            {
                return NotFound();
            }

            return autoes;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuto(int id, Auto auto)
        {
            if (id != auto.Code)
            {
                return BadRequest();
            }

            _context.Entry(auto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutoExists(id))
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

        [HttpPost]
        public async Task<ActionResult<Auto>> PostAuto(Auto auto)
        {
            _context.Auto.Add(auto);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AutoExists(auto.Code))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAutoes", new { id = auto.Code }, auto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Auto>> DeleteAuto(int id)
        {
            var auto = await _context.Auto.FindAsync(id);
            if (auto == null)
            {
                return NotFound();
            }

            _context.Auto.Remove(auto);
            await _context.SaveChangesAsync();

            return auto;
        }

        private bool AutoExists(int id)
        {
            return _context.Auto.Any(e => e.Code == id);
        }
    }
}
