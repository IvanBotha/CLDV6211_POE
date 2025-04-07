using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Venue
    {
        [Key]
        public int VenueID { get; set; }

        [Required]
        public string? VenueName { get; set; }

        [Required]
        public string? Location { get; set; }

        [Required]
        public int Capacity { get; set; }

        public string? ImageURL { get; set; }

        public ICollection<Event>? Events { get; set; }
        public ICollection<Booking>? Bookings { get; set; }
    }
}
