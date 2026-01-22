using System;

namespace code_smell
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call em all 🗣️ 🗣️ 
            HardcoreValues();
            LongFunction();
            DuplicateCode();
            LargeClass();
            DeeplyNestedConditionals();
        }

        // Magic Numbers & Strings – Using hardcoded values instead of constants.
        private static void HardcoreValues()
        {
            int age = 22; // Magic Number
            string status = "active"; // Magic String
            double discount = 0.15; // Magic Decimal Number
            Console.WriteLine($"Age: {age}, Status: {status}");
        }

        // Long Functions – Functions that do too much and should be broken into smaller parts.
        private static void LongFunction()
        {
            Console.WriteLine("Starting long function...");
            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine($"Processing item {i}");
            }
            Console.WriteLine("Long function completed.");
        }

        // Duplicate Code – Copy-pasting logic instead of reusing functions.
        private static void DuplicateCode()
        {
            Console.WriteLine("Starting long function...");
            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine($"Processing item {i}");
            }
            Console.WriteLine("Long function completed.");
            Console.WriteLine("Starting long function...");
            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine($"Processing item {i}");
            }
            Console.WriteLine("Long function completed.");
        }

        // Large Classes (God Objects) – Classes that handle too many responsibilities.
        private static void LargeClass()
        {
            User user = new User();
            user.Name = "John Doe";
            user.Email = "L1k9S@example.com";
            user.Password = "password123";
            user.Address = "123 Main St";
            user.Phone = "555-555-5555";

            Console.WriteLine($"User: {user.Name}, Email: {user.Email}");
        }

        // Deeply Nested Conditionals – Complex if/else trees that make code harder to follow.
        private static bool DeeplyNestedConditionals()
        {
            int number = 10;
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
                    if (number == 4)
                    {
                        return true;
                    }
                    else
                    {
                        if (number == 5)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
        }

        // Commented-Out Code – Unused code that clutters the codebase.
        private static void CommentedOutCode()
        {
            // This function is currently not in use
            // private static void UnusedFunction()
            // {
            //     Console.WriteLine("This function is commented out.");
            // }
        }

        // Inconsistent Naming – Variable names that don't clearly describe their purpose.
        private static void InconsistentNaming()
        {
            // Age of what?, status of whom?, discount for what?
            int age = 22;
            string status = "active";
            double discount = 0.15;
            Console.WriteLine($"Age: {age}, Status: {status}");
        }

        class User
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }

            // Too many responsibilities here
            public void SaveToDatabase() { }
            public void SendEmail() { }
            public void ValidatePassword() { }
            public void LogActivity() { }
            public void ExportToPdf() { }
        }

    }
}