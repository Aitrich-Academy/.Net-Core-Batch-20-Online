namespace EmpApp.Data
{
    public class EmployeeRepository
    {
        List<EmployeeDetails> employeeList = new List<EmployeeDetails>();

        public void Addemployee(EmployeeDetails employee)
        {
            employee.Id = employeeList.Count + 1;
            employeeList.Add(employee);
        }
        public List<EmployeeDetails> GetEmployee()
        {
            return employeeList;
        }

        public EmployeeDetails GetEmployeeById(int id)
        {
            return employeeList.FirstOrDefault
                (e => e.Id == id);
        }

        public void UpdateEmployee
            (EmployeeDetails employee)
        {
            EmployeeDetails EmployeeExist =
                GetEmployeeById(employee.Id);
            if (EmployeeExist != null)
            {
                EmployeeExist.Id = employee.Id;
                EmployeeExist.FirstName = employee.FirstName;
                EmployeeExist.LastName = employee.LastName;
                EmployeeExist.Email = employee.Email;
                EmployeeExist.Phone = employee.Phone;
            }
  
        }

        public void DeleteEmployee(EmployeeDetails employee)
        {
            EmployeeDetails EmployeeExist = GetEmployeeById(employee.Id);
            if (EmployeeExist != null)
            {
                employeeList.Remove(EmployeeExist);
            }
        }

    }
}
