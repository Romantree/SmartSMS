using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carriage_SMS_Project.COMMON
{
    public class OpcData : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _dataType;
        public string DataType
        {
            get { return _dataType; }
            set { _dataType = value; }
        }

        private string _value;
        public string Value
        {
            get { return _value; }
            set
            {
                _value = value;
                //OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
