namespace gift_of_the_giver.Models
{
    // FIX: Make the model public so it's visible to the controller
    public class DonationModel
    {
        public string DonorName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string DonationType { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
