
//Example 1: Magic Numbers & Strings
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

//-----------------------------------------------------------------------------------------

// Example 2: Long Function & Duplicate Code
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
//-----------------------------------------------------------------------------------------

// Example 3: Deeply Nested Conditionals
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
//-----------------------------------------------------------------------------------------

// Example 4: Large Class (God Object)
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