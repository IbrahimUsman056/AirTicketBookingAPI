using System;
using System.ComponentModel.DataAnnotations;

namespace AirTicketBookingAPI.Models
{
    public class Flight
    {
        [Key]
        public int FlightId { get; set; }

        [Required]
        [StringLength(10)]
        public string? FlightNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string? Airline { get; set; }

        [Required]
        [StringLength(50)]
        public string? FromCity { get; set; }

        [Required]
        [StringLength(50)]
        public string? ToCity { get; set; }

        [Required]
        public DateTime DepartureTime { get; set; }

        [Required]
        public DateTime ArrivalTime { get; set; }

        [Required]
        [Range(1, 100000)]
        public decimal TicketPrice { get; set; }

        [Required]
        [Range(0, 500)]
        public int AvailableSeats { get; set; }
    }
}
