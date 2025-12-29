using AirTicketBookingAPI.Data;
using AirTicketBookingAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AirTicketBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly AirTicketDbContext _context;

        public FlightsController(AirTicketDbContext context)
        {
            _context = context;
        }

        // GET: api/flights
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Flight>>> GetFlights()
        {
            return await _context.Flights.ToListAsync();
        }

        // GET: api/flights/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Flight>> GetFlight(int id)
        {
            var flight = await _context.Flights.FindAsync(id);

            if (flight == null)
                return NotFound();

            return flight;
        }

        // POST: api/flights
        [HttpPost]
        public async Task<ActionResult<Flight>> PostFlight(Flight flight)
        {
            if (flight.DepartureTime >= flight.ArrivalTime)
                return BadRequest("Departure time must be before arrival time.");

            if (flight.FromCity == flight.ToCity)
                return BadRequest("FromCity and ToCity cannot be the same.");

            _context.Flights.Add(flight);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFlight), new { id = flight.FlightId }, flight);
        }

        // PUT: api/flights/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFlight(int id, Flight flight)
        {
            if (id != flight.FlightId)
                return BadRequest();

            if (flight.DepartureTime >= flight.ArrivalTime)
                return BadRequest("Departure time must be before arrival time.");

            if (flight.FromCity == flight.ToCity)
                return BadRequest("FromCity and ToCity cannot be the same.");

            _context.Entry(flight).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/flights/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFlight(int id)
        {
            var flight = await _context.Flights.FindAsync(id);
            if (flight == null)
                return NotFound();

            _context.Flights.Remove(flight);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
