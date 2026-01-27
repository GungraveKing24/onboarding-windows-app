## 🔍 Research & Learn
---
#### What are the differences between unit testing and UI testing in WPF applications?
Unit test focus in Unit test on isolation and verifying individual components, while UI tests focus on validating the entire application user interfaces and user experience flow.

#### Which testing frameworks (e.g., NUnit, MSTest) and UI automation tools are commonly used for WPF apps?
For testing WPF applications, the most common unit testing frameworks are NUnit, xUnit, and MSTest, while popular UI automation tool include FLAUI, Windows Application Driver (WinAppDriver), and commercial options like TestComplete.

#### How can you design tests to cover critical functionalities and edge cases?
Design tests for critical functionality and edge cases require a risk-based approach, combining boundary value analisis, equivalence partitioning, and exploratory testing to cover both expected behaviors and, importantly, extreme or invalid scenarios.


## 📝 Reflection
---
#### How does implementing tests improve your development process?
How does implementing tests improve your development process?
It greatly helps in providing a guided overview of how the app works, as well as in finding and minimizing errors. It also allows for a better understanding of what each part of the code does beforehand, facilitating step-by-step code review.

#### Reflect on the trade-offs between the ease of unit tests and the complexity of UI tests.
Unit developments are generally easy, fast, and stable, while UI development tests are complex, slow, and fragile. 

#### What strategies could you employ to overcome challenges specific to testing WPF applications?
* Use MVVM strictly
* Avoid use code logic in the code-behind
* Dependency injection
* Test ViewModels, no Windows

## 🛠️ Task
---
#### Set up a simple WPF project that includes a core functionality.
Funcionalidad:
* A ViewModel to sum two numbers
```csharp
public class CalculatorViewModel
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}
```
#### Write unit tests using a framework of your choice to verify that functionality.
* Unit Test with NUnit

```csharp
[Test]
public void Add_ReturnsCorrectSum()
{
    var vm = new CalculatorViewModel();
    var result = vm.Add(2, 3);
    Assert.AreEqual(5, result);
}
```