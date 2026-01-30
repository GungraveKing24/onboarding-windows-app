using Microsoft.VisualBasic;
using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EventCommandWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        // Normal binding
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button example pressed", "Info");
        }

        //✅ Pros
        //    Simple
        //    Easy to understand

        //❌ Cons
        //    UI logic in code-behind
        //    Harder to test
        //    Poor MVVM compatibility
    }
}