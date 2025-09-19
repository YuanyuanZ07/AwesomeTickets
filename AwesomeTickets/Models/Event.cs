using System;
using System.ComponentModel.DataAnnotations;

namespace AwesomeTickets.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [StringLength(2000)]
        public string? Description { get; set; }

        [Required, StringLength(50)]
        public string Category { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan Time { get; set; }

        [Required, StringLength(200)]
        public string Location { get; set; } = string.Empty;

        [Required, StringLength(100)]
        public string Owner { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
