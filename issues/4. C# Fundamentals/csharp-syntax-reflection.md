## 🔍 Research & Learn
---
#### What are the primary data types in C# (e.g., int, string, bool, etc.)?

```csharp
int age = 22; //Integer numbre like 22 or -5
double pi = 3.1416 //Decimal numbers with high precision (32 bits)
float pi = 3.14  //Decimal numbers with less precision than double (64 bits)
bool status = false //Type boolean, 2 options (true or false)
char delete_character = "B" //Single character
string name = "Frank" // Text data including simbols, numbers and letters
decimal salary = 300.52 //High-precision numbers, often used for money
```

#### How do variables, constants, and operators function in C#?
```csharp
// Variables Store data that can change
int age = 20;

// Constansts store values that cannot change
const double pi = 3.1416

```

Operators perform actions on data:

* Arithmetic: + - * / %
* Comparison: == != > < >= <=
* Logical: && || !

#### What are the common pitfalls with type conversions in C#?
* Implicit vs Explicit casting
* Loss of precision when converting double → int
* Exceptions when parsing invalid strings
* Integer division truncation

Example:
```csharp
int a = 5/2; // Result is 2 entire numbre, no 2.5

// Safe conversion
int number;
bool success = int.TryParse("123", out number);
```

## 🛠️ Task
---
#### Example Program Using Multiple Data Types
```csharp
using System;

class Program
{
    static void Main()
    {
        int x = 10;
        double y = 3.5;
        bool isActive = true;

        double sum = x + y;
        Console.WriteLine($"Sum: {sum}")
        
        int converted = (int)y; // Explicit cast
        Console.WriteLine($"Converted double to int: {converted}");

        string input = "50";
        int parsed = int.Parse(input);
        Console.WriteLine($"Parsed number: {parsed}");
    }
}
```

## 📝 Reflection
---
#### Which aspects of C# syntax were new or surprising?
The strict type system and the different explicit conversion, especially compared to other dynamically typed languages.

#### How do data types influence performance and memory management in your code?
Choosing the right data type helps reduce RAM usage and improve application performance, especially in collections with large loops. Using the correct type allows you to use functions that don't consume more memory than necessary.

#### How do data types influence performance and memory management in your code?

* Use `TryParse` instead of `Parse`
* Avoid unnecessary conversions
* Choose the smallest and most appropriate data type