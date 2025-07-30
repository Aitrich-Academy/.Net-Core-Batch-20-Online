namespace BlazorApp2.Data
{
    public class EmployeeRepository
    {
        List<EmployeeDetails> EmployeeList = new List<EmployeeDetails>();

        public void AddEmployee(EmployeeDetails employee)
        {
            {
                employee.Id = EmployeeList.Count + 1;
                EmployeeList.Add(employee);
            }

        }
        public List<EmployeeDetails> GetAllEmployees()
        {
            return EmployeeList;
        }
    }
}
