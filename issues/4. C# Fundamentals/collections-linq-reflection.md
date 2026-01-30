#### What are the common collection types in C# (e.g., List, Dictionary, Array, etc.)?
* Array - Fixed'size, very fast acces by index.
* List - Dynamic array. Easy to add/remove items.
* Dictionary - Key-value pairs.
* HashSet - Store unique values only.

#### How does LINQ simplify data queries compared to traditional loops and conditional logic?
(Language Integrated Query), allows quering collections using a declarative syntax, reducing boilerplate code.

```csharp
// Traditional loop example
var result = new List<int>();

foreach (var n  in numbers)
{
    if (n>10)
        result.Add(n)
}

// LINQ example of the same code
var result = numbers.Where(n => n > 10).ToList();

// The diferents benefits
// - Less code
// - Easier to read
// - Focus on what you want, not how to do it
```

#### What are some performance considerations when choosing a collection type?
* Arrays: Fast acces, but fixed size
* List: Very good for general purpose
* Dictionary: Best for frequent lookups by key
* LINQ: Improves readability but may allocate extra memory
* Avoid LINQ in tight loops or sections that requires critical-performance

---
## 🛠️ Task
### Example using collections + LINQ

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

class program 
{
    static void Main()
    {
        List<int> numbers = new List<int> {5, 1, 62, 65, 421, 20}
        
        Dictionary<int, string> students = new Dictionary<int, string>
        {
            { 1, "Ana" },
            { 2, "Luis" },
            { 3, "Carlos" }
        };

        Console.WriteLine("Numers greater than 50")
        var filtered numbers = numbers.Where(n => n > 50).OrderBy(n => n)

        Console.WriteLine($"Student with ID 2: {students[2]}")
    }
}
```
---
## 📝 Reflection

#### Most useful collection types
* List for most data handling due to flexibility
* Dictionary<TKey, TValue> when fast lookups are required

#### How LINQ Improves Readability and Efficiency
It reduces nested loops and conditionals, making code easier to understand and maintain. It allows you to express queries that might otherwise take several lines in just one or a few lines, depending on the use case and complexity.

#### When LINQ Simplifies Code
Filtering, sorting, grouping, and transforming collections is greatly simplified using LINQ instead of the traditional iterative approach.