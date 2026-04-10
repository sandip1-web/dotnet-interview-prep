## 🔹 LINQ Example: Filter and Select Data

### 📌 Problem

From a list of employees:

- Get employees with salary > 50,000
- Display only their Name and Salary

---

### 💻 Code

```csharp id="6bnc9p"
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

        var result = employees
            .Where(emp => emp.Salary > 50000)
            .Select(emp => new { emp.Name, emp.Salary });

        foreach (var item in result)
        {
            Console.WriteLine($"{item.Name} - {item.Salary}");
        }
    }
}

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
}
```

---

### ✅ Output

```id="k8aqre"
Sandip - 60000
Rahul - 70000
```

---

### 🧠 Explanation

- `Where()` → Filters data (like SQL WHERE)
- `Select()` → Projects required fields (like SQL SELECT)
- Anonymous type → `new { emp.Name, emp.Salary }`

---

### 🔥 Interview Questions

👉 Q1: Difference between `Where` and `Select`

- `Where` → Filtering
- `Select` → Projection

👉 Q2: Can we use Select without Where?
✔ Yes

👉 Q3: Execution type?
✔ Deferred execution (until iteration)

---

### 🚀 Advanced Version (Method + Query Syntax)

```csharp id="npr39q"
// Query Syntax
var result = from emp in employees
             where emp.Salary > 50000
             select new { emp.Name, emp.Salary };
```
