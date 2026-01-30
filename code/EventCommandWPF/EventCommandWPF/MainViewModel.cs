using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace EventCommandWPF
{
    internal class MainViewModel
    {
        public ICommand ClickCommand { get; }
        public MainViewModel()
        {
            ClickCommand = new RelayCommand(OnClick);
        }

        public void OnClick()
        {
            MessageBox.Show("Button clicked using command!");
        }
    }
}
