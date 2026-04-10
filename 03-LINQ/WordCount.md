## 🔹 LINQ Example: Word Count in String

### 📌 Problem

Count the frequency of each word in a given string using LINQ.

### 💻 Code

```csharp
using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string str = "this is dotnet and this is csharp";

        var result = str
            .ToLower()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .GroupBy(x => x)
            .Select(g => new { Word = g.Key, Count = g.Count() });

        foreach (var item in result)
        {
            Console.WriteLine($"{item.Word} : {item.Count}");
        }

    }
}
```

### ✅ Output

```
this 2
is 2
dotnet 1
and 1
csharp 1
```

### 🧠 Explanation

- `Split(' ')` → Converts string into words
- `GroupBy(x => x)` → Groups same words
- `item.Key` → Word
- `item.Count()` → Frequency of word

### 🚀 Improvement (Case-Insensitive)

```csharp
var result = str
    .ToLower()
    .Split(' ')
    .GroupBy(x => x);
```
