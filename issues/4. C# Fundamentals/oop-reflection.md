## 🔍 Research & Learn
---
#### What are the four main pillars of OOP in C#?
- Encapsulation: Bundling data and behavior together and restricting direct access.
- Inheritance: Creating new classes based on existing ones to reuse behavior.
- Polymorphism: Treating related objects uniformly while allowing different behavior.
- Abstraction: Exposing only essential details and hiding implementation complexity.

#### How do concepts like inheritance, polymorphism, and encapsulation manifest in C# code?

##### Concepts in C# Code

```csharp
// Encapsulation
// Controlling access using private, protected, and public
class User
{
    private string password;

    public void SetPassword(string value)
    {
        password = value
    }
}

// Inheritance & Polymorphism
// A dog is an animala but it behaves differently
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal sound");
    }
}

class Dog : Animal // Using Animal class for the dog
{
    public override void Speak()
    {
        Console.WriteLine("Bark");
    }
}

// Abstraction
// Forces derived classes to implement required behavior
abstract class Shape
{
    public abstract double Area();
}

// Rectangle and Circle both implement Area, but use different methods
// The abstraction form has no idea what shape it is; it only knows that it's a shape and that the shape has an Area
class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }

    public Rectange(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double Area()
    {
        return Width * Height;
    }
}

class Circle : Shape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}
```

#### Which design patterns leverage OOP principles to improve code structure?
* Factory Pattern – Encapsulates object creation
* Singleton Pattern – Ensures a single instance exists
* Strategy Pattern – Enables interchangeable behavior
* Observer Pattern – Enables event-based communication

Patterns improve scalability, testing, and separation of concerns

## 📝 Reflection
----
#### Which OOP principle did you find most challenging and why?
Polymorphism requires thinking in terms of interfaces and base classes rather than concrete implementations; abstraction is also used to manage complexity by hiding implementation details and showing only the essential functionalities of an object, because it focuses on what an object does rather than how it does it.

#### How does applying OOP concepts enhance code reusability and maintainability?
Through inheritance and composition, while encapsulation ensures that changes remain well localized and are easier to find and manage.

#### Reflect on a scenario where using OOP made a project easier to manage.
By using base classes, you simplify the incorporation of functions without modifying all the existing logic, which helps reduce the number of errors and improves scalability.

---
## 🛠️ Task
---
#### Create a simple class hierarchy in C# demonstrating inheritance and polymorphism.

#### Implement one design pattern (e.g., Factory or Singleton) in your example.

##### Code in C#:

```csharp
using System;
using System.Collections.Generic;

// Class Hierarchy + Polymorphism
abstract class Vehicle
{
    public abstract void Move();
}

class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Car is driving");
    }
}

class Bike : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Bike is riding");
    }
}

// Factory Pattern Example
class VehicleFactory
{
    public static Vehicle Create (string type)
    {
        return type switch
        {
            "car" => new Car(),
            "bike" => new Bike(),
            _ => throw new ArgumentException("Invalid vehicle type")
        };
    }
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            VehicleFactory.Create("car"),
            VehicleFactory.Create("bike")
        };

        foreach (var v in vehicles)
        {
            v.Move; // Polymorphism in action
        }
    }
}
```