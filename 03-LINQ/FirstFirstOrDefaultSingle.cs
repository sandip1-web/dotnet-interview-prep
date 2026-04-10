using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static void Main()
  {
    var employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Sandip", Salary = 60000 },
            new Employee { Id = 2, Name = "Amit", Salary = 40000 },
            new Employee { Id = 3, Name = "Rahul", Salary = 70000 }
        };

    // First
    var firstEmp = employees.First(emp => emp.Salary > 50000);

    // FirstOrDefault
    var firstOrDefaultEmp = employees.FirstOrDefault(emp => emp.Salary > 50000);

    // Single
    var singleEmp = employees.Single(emp => emp.Id == 1);

    // SingleOrDefault
    var singleOrDefaultEmp = employees.SingleOrDefault(emp => emp.Id == 10);

    Console.WriteLine(firstEmp.Name);
    Console.WriteLine(firstOrDefaultEmp?.Name);
    Console.WriteLine(singleEmp.Name);
    Console.WriteLine(singleOrDefaultEmp == null ? "Not Found" : singleOrDefaultEmp.Name);
  }
}

public class Employee
{
  public int Id { get; set; }
  public string Name { get; set; }
  public int Salary { get; set; }
}