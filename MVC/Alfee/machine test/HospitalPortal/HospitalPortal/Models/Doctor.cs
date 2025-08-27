namespace HospitalPortal.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Specialization { get; set; } = string.Empty;
        public string AvailableDays { get; set; } = string.Empty;   // Example: "Mon, Wed, Fri"
        public string AvailableTime { get; set; } = string.Empty;
    }
}
