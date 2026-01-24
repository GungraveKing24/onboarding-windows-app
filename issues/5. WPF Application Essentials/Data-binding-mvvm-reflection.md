## 🔍 Research & Learn
---
#### What is data binding in WPF, and what are its different modes (OneWay, TwoWay, etc.)?
Data binding is a mechanism that connects UI elements (View) to data sources (ViewModel or Model), allowing automatic synchronization.

Common Binding Modes:
* OneWay – Data flows from ViewModel → View (most common for display)
* TwoWay – Data flows both ways (e.g., TextBox input)
* OneTime – Data is set once and never updated
* OneWayToSource – Data flows from View → ViewModel

Example:
```csharp
<Text Text="{Binding Username, Mode=TwoWay}"
```

#### How does the MVVM pattern organize code, and what are the roles of the Model, View, and ViewModel?
Model-View-ViewModel organizes WPF applications by separating responsibilities:
* Model – Business logic and data (e.g., User, Product)
* View – XAML UI, no logic
* ViewModel – Presentation logic and data binding layer

This separation is a good improve when you need maintainability, testability and scalabilty.

#### What are some common pitfalls when implementing data binding and MVVM, and how can they be mitigated?
* ❌ Foget ti implement `INotifyPropertyChanged`
    * ✅ Always notify UI or property updates
* ❌ Tight coupling between View and ViewModel
    * ✅ Avoid code-behind logic
* ❌ Overusing code-behind events
    * ✅ Prefer `ICommand`
* ❌ Complex ViewModels
    *✅ Split responsibilities into smaller ViewModels

## 📝 Reflection
---
#### How does data binding improve separation of concerns in your application?
The UI doesn't need to know how the data is managed, only what data it should display. Keeping the logic out of view.

#### Consider how MVVM can simplify testing and maintenance.
In several ways, view models can be unit tested without the UI, and UI changes can be displayed independently.

#### What challenges might arise when applying these concepts to larger applications?
Managing many views simultaneously that depend on one or more other views, or even an excessive number of views, is difficult. Binding views overloaded with properties or arrays is also very complex and difficult to optimize.

## 🛠️ Task
---
#### Create a simple WPF project that demonstrates data binding between the UI and a ViewModel.
Example code:

MainWindow.cs
```csharp
using System.Windows;

namespace SampleApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new UserViewModel { Name = "Alice", Age = 30 };
        }
    }
}
```

model.cs
```csharp
namespace SampleApp
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
```

UserViewModel.cs
```csharp
using System.ComponentModel;

namespace SampleApp
{
    class UserViewModel : INotifyPropertyChanged
    {
        private string name;
        private int age;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        public int Age
        {
            get => age;
            set
            {
                age = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Age)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
```

UserViewModel.xaml
```csharp
<Window x:Class="SampleApp.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="MVVM Demo" Height="200" Width="300">
    <StackPanel Margin="20">
        <TextBlock Text="Name:" FontWeight="Bold"/>
        <TextBox Text="{Binding Name, Mode=TwoWay}" Padding="5" Margin="0,0,0,10"/>
        <TextBlock Text="Your Name:" FontWeight="Bold"/>
        <TextBlock Text="{Binding Name}" FontSize="16" Padding="5"/>
        <TextBlock Text="Age:" FontWeight="Bold" Margin="0,10,0,0"/>
        <TextBlock Text="{Binding Age}" FontSize="16" Padding="5"/>
    </StackPanel>
</Window>
```