

public class Program
{
  public static void Main(string[] args)
  {
    var employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Sandip", Salary = 60000 },
            new Employee { Id = 2, Name = "Amit", Salary = 60000 },
            new Employee { Id = 3, Name = "Rahul", Salary = 40000 }
        };

    var result = employees
        .OrderBy(emp => emp.Salary)
        .ThenBy(emp => emp.Name);

    foreach (var emp in result)
    {
      Console.WriteLine($"{emp.Name} - {emp.Salary}");
    }
  }
}

public class Employee
{
  public int Id { get; set; }
  public string Name { get; set; }
  public int Salary { get; set; }
}