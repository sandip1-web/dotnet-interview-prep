## 🔹 LINQ Example: First vs FirstOrDefault vs Single

### 📌 Problem

Find employee with Salary > 50,000

---

### 💻 Code

```csharp id="2k9s8d"
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
```

---

### 🧠 Explanation

#### ✅ First()

- Returns **first matching element**
- ❌ Throws exception if no match

---

#### ✅ FirstOrDefault()

- Returns first match
- ✔ Returns `null` if no match

---

#### ✅ Single()

- ✔ Expects **exactly ONE** match
- ❌ Throws exception if:
  - No record OR
  - More than one record

---

#### ✅ SingleOrDefault()

- ✔ Returns single match
- ✔ Returns `null` if no match
- ❌ Throws if multiple records found

---

### 🔥 Interview Traps (Very Important)

👉 Q1: When to use `Single`?
✔ When data must be **unique** (e.g., ID)

👉 Q2: Safer option?
✔ `FirstOrDefault()` (avoids exception)

👉 Q3: Difference between First & Single?

- `First` → at least one
- `Single` → exactly one

---

### ⚠️ Example of Exception

```csharp id="f3l9q2"
// This will throw exception if multiple employees have Salary > 50000
var emp = employees.Single(e => e.Salary > 50000);
```

---

### 🚀 Best Practice

```csharp id="l2p8m4"
var emp = employees.FirstOrDefault(e => e.Id == 10);

if (emp != null)
{
    Console.WriteLine(emp.Name);
}
```
