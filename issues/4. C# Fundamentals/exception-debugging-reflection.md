# 🎯 Exception Handling & Debugging in C# — Reflection

## 🔍 Research & Learn

### Best Practices for Exception Handling in C#

* **Use exceptions for exceptional cases only**, not normal control flow.
* **Catch specific exceptions** (e.g., `FileNotFoundException`) instead of `Exception` when possible.
* **Do not swallow exceptions** — always log or handle them meaningfully.
* **Use `finally`** for cleanup (closing files, releasing resources).
* **Let exceptions bubble up** if you can’t handle them properly at the current level.
* **Add context** when rethrowing exceptions using `throw;` or wrapping with a custom exception.

### How do try-catch-finally blocks work, and when should you use them?

```csharp
try
{
    // Code that may throw an exception
}
catch (SpecificException ex)
{
    // Handle known exception
}
catch (Exception ex)
{
    // Handle unexpected exception
}
finally
{
    // Always runs (cleanup code)
}
```

**When to use it:**

* When working with files, databases, APIs, or user input
* When cleanup is required regardless of success or failure

### Visual Studio Debugging Tools

* **Breakpoints** – Pause execution at a specific line
* **Step Over (F10)** – Execute line by line
* **Step Into (F11)** – Dive into method calls
* **Step Out (Shift + F11)** – Exit the current method
* **Watch / Locals Window** – Inspect variable values
* **Exception Settings** – Break when an exception is thrown
* **Call Stack** – See how the code reached the current point

---

## 🛠️ Task

### Example Program (Intentional Exception)

```csharp
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            int result = 10 / number; // Can cause DivideByZeroException
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: You cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid number format.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Execution finished.");
        }
    }
}
```

### Debugging Steps in Visual Studio

1. Place a **breakpoint** on the `int result = 10 / number;` line
2. Run the program in debug mode
3. Enter `0` or a non-number
4. Use **Step Over (F10)** to observe exception flow
5. Check **Call Stack** and **Locals** when the exception occurs

---

## 📝 Reflection

### When did exception handling prevent a major issue?
Proper exception handling prevented the app from crashing when the user provided invalid input, allowing the program to recover from the error by reporting what mistake the user made.

### Most effective debugging techniques
* Puntos de interrupcion usando Step Over para analizar el flujo de la app
* Visualizar los valores reales que esta recogiendo en tiempo real
* Configurar interrupciones para detectar errores de forma temprana 

### How to improve error logging & reporting

* Use a logging framework
* Log exception messages with stack traces
* Centralize error handling where possible