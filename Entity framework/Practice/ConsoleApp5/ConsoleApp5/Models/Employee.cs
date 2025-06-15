using System;
using System.Collections.Generic;

namespace ConsoleApp5.Models;

public partial class Employee
{
    public int EmpId { get; set; }

    public string? EmpName { get; set; }

    public int? DepartmentId { get; set; }

    public decimal? Salary { get; set; }

    public DateOnly? HireDate { get; set; }

    public virtual Department? Department { get; set; }
}
