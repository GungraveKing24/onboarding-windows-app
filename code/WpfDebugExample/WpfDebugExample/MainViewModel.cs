using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace WpfDebugExample
{
    class MainViewModel : INotifyPropertyChanged
    {
        private int _result;

        public int NumberA { get; set; }
        public int NumberB { get; set; }

        public int Result
        {
            get => _result;
            set
            { 
                _result = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Result)));
            }
        }

        public void Calculate()
        {
            Result = NumberA + NumberB;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
