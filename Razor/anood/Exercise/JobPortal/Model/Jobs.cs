namespace JobPortal.Model
{
    public class Jobs
    {
        internal string Title;

        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string EmploymentType { get; set; }
        public string SalaryRange { get; set; }
        public string JobDescription { get; set; }
    }
}
