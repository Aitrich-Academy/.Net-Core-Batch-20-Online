namespace EmpApp.Data
{
    public class EmployeeService
    {
        EmployeeRepository _empRepository;
        public EmployeeService(EmployeeRepository empRepository)
        {
            _empRepository = empRepository;
        }

        public void AddEmployeeList(EmployeeDetails employeeDetails)
        {
            _empRepository.Addemployee(employeeDetails);
        }

        public List<EmployeeDetails> GetEmployeeList()
        {
            return _empRepository.GetEmployee();
        }

        public EmployeeDetails GetEmployeeListById(int id)
        {
            return _empRepository.GetEmployeeById(id);
        }

        public void UpdateEmployeeList(EmployeeDetails employee)
        {
            _empRepository.UpdateEmployee(employee);
        }


        public void DeleteEmployeeList(EmployeeDetails employee)
        {
            _empRepository.DeleteEmployee(employee);
        }

    }
}
