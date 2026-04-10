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

    // Any
    bool hasHighSalary = employees.Any(emp => emp.Salary > 50000);

    // All
    bool allAboveThirty = employees.All(emp => emp.Salary > 30000);

    Console.WriteLine("Any employee with salary > 50000: " + hasHighSalary);
    Console.WriteLine("All employees salary > 30000: " + allAboveThirty);
  }
}

public class Employee
{
  public int Id { get; set; }
  public string Name { get; set; }
  public int Salary { get; set; }
}