using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.ViewModel
{
    public class TimetableViewModel : INotifyPropertyChanged
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
        int _MatchID;
        public int MatchID
        {
            get
            {
                return _MatchID;
            }
            set
            {
                if (_MatchID != value)
                {
                    _MatchID = value;
                    RaisePropertyChanged("MatchID");
                }
            }
        }

        int _RefereeID;
        public int RefereeID
        {
            get
            {
                return _RefereeID;
            }
            set
            {
                if (_RefereeID != value)
                {
                    _RefereeID = value;
                    RaisePropertyChanged("RefereeID");
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
