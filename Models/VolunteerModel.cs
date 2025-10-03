using System;
using System.ComponentModel.DataAnnotations;

namespace gift_of_the_giver.Models
{
    public class VolunteerModel
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Task { get; set; } = string.Empty; // single task assigned

        [Required]
        public string Schedule { get; set; } = string.Empty; // e.g., "Mon-Fri, 9am-12pm"

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateJoined { get; set; } = DateTime.Now;
    }
}
