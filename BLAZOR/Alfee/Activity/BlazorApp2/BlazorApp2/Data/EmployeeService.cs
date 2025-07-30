namespace BlazorApp2.Data
{
    public class EmployeeService
    {
        EmployeeRepository repository;

        public EmployeeService(EmployeeRepository emprepository)
        {
            repository = emprepository;
        }

        public void AddEmployeeList(EmployeeDetails employee)
        {
            repository.AddEmployee(employee);
        }

        public List<EmployeeDetails> GetEmployeeList()
        {
            return repository.GetAllEmployees();
        }
    }
}

