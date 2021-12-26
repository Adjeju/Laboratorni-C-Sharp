using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarDbsController : Controller
    {
        private readonly CarDBContext _context;

        public CarDbsController(CarDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarDb>>> GetCars()
        {
            return await _context.CarDb.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CarDb>> GetCars(int id)
        {
            var cars = await _context.CarDb.FindAsync(id);

            if (cars == null)
            {
                return NotFound();
            }

            return cars;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCar(int id, CarDb cars)
        {
            if (id != cars.Id)
            {
                return BadRequest();
            }

            _context.Entry(cars).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarExists(id))
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
        public async Task<ActionResult<CarDb>> PostPersons(CarDb cars)
        {
            _context.CarDb.Add(cars);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CarExists(cars.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCars", new { id = cars.Id }, cars);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CarDb>> DeleteCars(int id)
        {
            var cars = await _context.CarDb.FindAsync(id);
            if (cars == null)
            {
                return NotFound();
            }

            _context.CarDb.Remove(cars);
            await _context.SaveChangesAsync();

            return cars;
        }

        private bool CarExists(int id)
        {
            return _context.CarDb.Any(e => e.Id == id);
        }

    }
}
