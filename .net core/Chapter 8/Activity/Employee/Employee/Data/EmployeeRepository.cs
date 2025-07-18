namespace Employee.Data
{
    public class EmployeeRepository
    {
        List<EmployeeDetails> EmployeeList = new List<EmployeeDetails>();

        public void AddEmployee
            (EmployeeDetails employee)
        {
            employee.Id = EmployeeList.Count + 1;
            EmployeeList.Add(employee);
        }

        public List<EmployeeDetails> GetEmployee()
        {
            return EmployeeList;
        }

        public EmployeeDetails GetEmployeeById(int id)
        {
            return EmployeeList.FirstOrDefault
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
                EmployeeExist.FirstName= employee.FirstName;
                EmployeeExist.LastName= employee.LastName;
                EmployeeExist.Email= employee.Email;
                EmployeeExist.Phone= employee.Phone;
            }
        }

        public void DeleteEmployee(EmployeeDetails employee)
        {
            EmployeeDetails EmployeeExist= GetEmployeeById(employee.Id);
            if (EmployeeExist != null) 
            {
                EmployeeList.Remove(EmployeeExist);
            } 
        }
    }
}
