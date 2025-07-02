using JobManagement.Model;

namespace JobManagement.Dto
{
    public class JobDto
    {
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string EmploymentType { get; set; }
        public string SalaryRange { get; set; }
        public string JobDescription { get; set; }
        public string Requirements { get; set; }

        public static implicit operator JobDto(Jobs v)
        {
            throw new NotImplementedException();
        }
    }
}
