using System;
using System.ComponentModel.DataAnnotations;

namespace gift_of_the_giver.Models
{
    public class DisasterModel
    {
        [Required]
        public string DisasterType { get; set; } = string.Empty;

        [Required]
        public string Location { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
