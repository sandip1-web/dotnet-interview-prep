## 🔹 LINQ Example: Sorting Data using OrderBy & ThenBy

### 📌 Problem

Sort employees:

1. First by Salary (Ascending)
2. Then by Name (Ascending)

---

### 💻 Code

```csharp
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
```

---

### ✅ Output

```
Rahul - 40000
Amit - 60000
Sandip - 60000
```

---

### 🧠 Explanation

- `OrderBy()` → Primary sorting
- `ThenBy()` → Secondary sorting
- Sorting is **stable** (maintains order)

---

### 🔥 Interview Questions

👉 Q1: Difference between `OrderBy` and `ThenBy`

- `OrderBy` → First level sorting
- `ThenBy` → Secondary sorting

👉 Q2: Descending sorting?
✔ Use `OrderByDescending()` / `ThenByDescending()`

---

### 🚀 Advanced Example (Descending)

```csharp id="7r6v0o"
var result = employees
    .OrderByDescending(emp => emp.Salary)
    .ThenBy(emp => emp.Name);
```

---

### 🔄 Query Syntax

```csharp id="3i9y2v"
var result = from emp in employees
             orderby emp.Salary, emp.Name
             select emp;
```
