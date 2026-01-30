## 🔍 Code Smells & Refactoring

### What code smells did you find in your code?
In my sample code, I intentionally included several common code smells:
- **Magic numbers and strings**
- **Long functions**
- **Duplicate code**
- **Large classes (God Objects)**
- **Deeply nested conditionals**
- **Inconsistent naming**

#### How did refactoring improve the readability and maintainability of the code?
Refactoring made the code easier to read by reducing complexity, removing duplication, and clarifying intent through better naming and structure. Smaller, focused methods are easier to debug and reuse.

#### How can avoiding code smells make future debugging easier?
Avoiding code smells reduces hidden dependencies and unclear logic. This makes bugs easier to locate and fix, especially as the codebase grows.

[text](../../code/code_smell.cs)

Each example shows how these issues reduce readability and make maintenance harder.
**Before (code smell):**

Example 1: Magic Numbers & Strings
```csharp
// Before
int age = 22;
string status = "active";
double discount = 0.15;

// After
const int DefaultUserAge = 22;
const string ActiveStatus = "active";
const double DefaultDiscountRate = 0.15;

int age = DefaultUserAge;
string status = ActiveStatus;
double discount = DefaultDiscountRate;
```

Example 2: Long Function & Duplicate Code
```csharp
//Before
private static void LongFunction()
{
    Console.WriteLine("Starting long function...");
    for (int i = 0; i < 40; i++)
    {
        Console.WriteLine($"Processing item {i}");
    }
    Console.WriteLine("Long function completed.");
}

// After
private static void ProcessItems(int count)
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"Processing item {i}");
    }
}

private static void RefactoredFunction()
{
    Console.WriteLine("Starting process...");
    ProcessItems(40);
    Console.WriteLine("Process completed.");
}
```

Example 3: Deeply Nested Conditionals
```csharp
// Before
if (number == 1)
{
    return false;
}
else if (number == 2)
{
    return true;
}
else
{
    if (number == 3)
    {
        return false;
    }
    else
    {
        return true;
    }
}

// After
return number == 2 || number == 4;
```

Example 4: Large Class (God Object)
```csharp
// Before
class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public void SaveToDatabase() { }
    public void SendEmail() { }
    public void ExportToPdf() { }
}

// After
class User
{
    public string Name { get; set; }
    public string Email { get; set; }
}

class UserRepository
{
    public void Save(User user) { }
}

class EmailService
{
    public void SendEmail(User user) { }
}
```