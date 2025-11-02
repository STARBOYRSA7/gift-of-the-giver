namespace gift_of_the_giver.Models
{
    public class VolunteerModel
    {
        public string VolunteerName { get; set; } = string.Empty;
        public string Tasks { get; set; } = string.Empty;
        public string Schedule { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty; // Filled from session
    }
}
