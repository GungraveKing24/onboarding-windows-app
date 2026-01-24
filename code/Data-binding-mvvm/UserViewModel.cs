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