using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.ViewModel
{
    public class TrainingStaffViewModel : INotifyPropertyChanged
    {
        int _ID;
        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    _ID = value;
                    RaisePropertyChanged("ID");
                }
            }
        }
        int _age;
        public int age
        {
            get
            {
                return _age;
            }
            set
            {
                if (_age != value)
                {
                    _age = value;
                    RaisePropertyChanged("age");
                }
            }
        }
        string _duty;
        public string duty
        {
            get
            {
                return _duty;
            }
            set
            {
                if (_duty != value)
                {
                    _duty = value;
                    RaisePropertyChanged("duty");
                }
            }
        }
        string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    RaisePropertyChanged("FirstName");
                }
            }
        }
        string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    RaisePropertyChanged("LastName");
                }
            }
        }
        string _ClubName;
        public string ClubName
        {
            get
            {
                return _ClubName;
            }
            set
            {
                if (_ClubName != value)
                {
                    _ClubName = value;
                    RaisePropertyChanged("ClubName");
                }
            }
        }
        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
