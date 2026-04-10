using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static void Main(string[] args)
  {
    var employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Sandip", Salary = 60000 },
            new Employee { Id = 2, Name = "Amit", Salary = 40000 },
            new Employee { Id = 3, Name = "Rahul", Salary = 70000 }
        };

    IEnumerable<EmployeeDto>? result = employees
        .Where(emp => emp.Salary > 50000)
        .Select(emp => new EmployeeDto { EmployeeName = emp.Name, EmployeeSalary = emp.Salary });
    if (result != null)
    {
      foreach (EmployeeDto item in result)
      {
        Console.WriteLine($"{item.EmployeeName} - {item.EmployeeSalary}");
      }

    }

  }
}

public class EmployeeDto
{
  public string EmployeeName { get; set; }
  public double EmployeeSalary { get; set; }
}
public class Employee
{
  public int Id { get; set; }
  public string Name { get; set; }
  public int Salary { get; set; }
}