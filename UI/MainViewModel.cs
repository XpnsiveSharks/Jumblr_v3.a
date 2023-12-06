using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Jumblr_v3.a.UI
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private UserControl _currentControl;

        public UserControl CurrentControl
        {
            get { return _currentControl; }
            set
            {
                _currentControl = value;
                OnPropertyChanged(nameof(CurrentControl));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
