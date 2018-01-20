using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.ViewModel
{
    public class WinnersViewModel : INotifyPropertyChanged
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
        int _goalsScored;
        public int goalsScored
        {
            get
            {
                return _goalsScored;
            }
            set
            {
                if (_goalsScored != value)
                {
                    _goalsScored = value;
                    RaisePropertyChanged("goalsScored");
                }
            }
        }
        int _goalsLost;
        public int goalsLost
        {
            get
            {
                return _goalsLost;
            }
            set
            {
                if (_goalsLost != value)
                {
                    _goalsLost = value;
                    RaisePropertyChanged("goalsLost");
                }
            }
        }
        int _wonMatches;
        public int wonMatches
        {
            get
            {
                return _wonMatches;
            }
            set
            {
                if (_wonMatches != value)
                {
                    _wonMatches = value;
                    RaisePropertyChanged("wonMatches");
                }
            }
        }
        int _clubID;
        public int clubID
        {
            get
            {
                return _clubID;
            }
            set
            {
                if (_clubID != value)
                {
                    _clubID = value;
                    RaisePropertyChanged("clubID");
                }
            }
        }
        int _lostMatches;
        public int lostMatches
        {
            get
            {
                return _lostMatches;
            }
            set
            {
                if (_lostMatches != value)
                {
                    _lostMatches = value;
                    RaisePropertyChanged("lostMatches");
                }
            }
        }
        string _year;
        public string year
        {
            get
            {
                return _year;
            }
            set
            {
                if (_year != value)
                {
                    _year = value;
                    RaisePropertyChanged("year");
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
