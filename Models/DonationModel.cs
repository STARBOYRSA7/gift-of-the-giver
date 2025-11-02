using System;

namespace gift_of_the_giver.Models
{
    public class ExistingDonationModel
    {
        public string DonorName { get; set; } = string.Empty;

        [Required]
        public string ResourceType { get; set; } = string.Empty; // instead of DonationType

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public int Quantity { get; set; } = 1;

        [DataType(DataType.Date)]
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
