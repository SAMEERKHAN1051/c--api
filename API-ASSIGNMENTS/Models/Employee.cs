using System;
using System.Collections.Generic;

namespace API_ASSIGNMENTS.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? EmpName { get; set; }

    public string? EmpEmail { get; set; }

    public int? EmpSalary { get; set; }

    public string? EmpPhone { get; set; }
}
