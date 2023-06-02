using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YJH
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        string _text1;
        public string Text1
        {
            get => _text1;
            set
            {
                _text1 = value;
                OnPropertyChanged("Text1");
            }
        }
        string _text2;
        public string Text2
        {
            get => _text2;
            set
            {
                _text2 = value;
                OnPropertyChanged("Text2");
            }
        }

        string _text3;
        public string Text3
        {
            get => _text3;
            set
            {
                _text3 = value;
                OnPropertyChanged("Text3");
            }
        }

        string _text4;
        public string Text4
        {
            get => _text4;
            set
            {
                _text4 = value;
                OnPropertyChanged("Text3");
            }
        }
        public MainWindowViewModel()
        {
            Text1 = "히히";
            Text2 = "하하";
            Text3 = "히히";
            Text4 = "하하";
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
