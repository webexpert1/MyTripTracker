using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripTracker.BackService.Data;
using TripTracker.BackService.Models;

namespace TripTracker.BackService.Controllers
{
    [Route("api/[controller]")]
    public class TripsController: Controller
    {
        private readonly TripContext _context;

        public TripsController(TripContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var trips = await _context.Trips.AsNoTracking().ToListAsync();
            return Ok(trips);
        }
        [HttpGet("{id}")]
        public  Trip Get(int id)
        {
            return _context.Trips.Find(id);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Trip trip)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Trips.Add(trip);
            await  _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Trip trip)
        {
            if (_context.Trips.Find(id) == null)
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Trips.Update(trip);
            await _context.SaveChangesAsync();

            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var myTrip = _context.Trips.Find(id);

            if (myTrip == null)
                return NotFound();

            _context.Trips.Remove(myTrip);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
