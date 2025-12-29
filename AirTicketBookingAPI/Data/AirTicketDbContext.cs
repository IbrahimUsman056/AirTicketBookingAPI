using Microsoft.EntityFrameworkCore;
using AirTicketBookingAPI.Models;

namespace AirTicketBookingAPI.Data
{
    public class AirTicketDbContext : DbContext
    {
        public AirTicketDbContext(DbContextOptions<AirTicketDbContext> options)
            : base(options)
        {
        }

        public DbSet<Flight> Flights { get; set; }
    }
}
