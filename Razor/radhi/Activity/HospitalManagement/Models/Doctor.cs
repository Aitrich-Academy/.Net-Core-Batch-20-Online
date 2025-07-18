namespace HospitalManagement.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
      
        public string Qualification { get; set; }
        public string OP_Time { get; set; }
        public string Department { get; set; }
        public int Experience { get; set; }
    }
}
