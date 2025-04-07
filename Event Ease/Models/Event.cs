using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventEase.Models
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }

        [Required]
        public string? EventName { get; set; }

        [Required]
        public DateTime EventDate { get; set; }

        public string? Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public int VenueID { get; set; }

        [ForeignKey("VenueID")]
        public Venue? Venue { get; set; }

        public ICollection<Booking>? Bookings { get; set; }
    }
}
