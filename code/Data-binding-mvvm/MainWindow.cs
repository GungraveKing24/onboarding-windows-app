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