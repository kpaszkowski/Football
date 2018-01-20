using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.ViewModel
{
    public class ClubViewModel : INotifyPropertyChanged
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
        string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (_Name != value)
                {
                    _Name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }

        string _Stadium;
        public string Stadium_Name
        {
            get
            {
                return _Stadium;
            }
            set
            {
                if (_Stadium != value)
                {
                    _Stadium = value;
                    RaisePropertyChanged("Stadium");
                }
            }
        }

        int _RecordID;
        public int RecordID
        {
            get
            {
                return _RecordID;
            }
            set
            {
                if (_RecordID != value)
                {
                    _RecordID = value;
                    RaisePropertyChanged("RecordID");
                }
            }
        }

        public void UpdateFromModel(Club club)
        {
            //this.ID = club.id;
            this.Name = club.name;
            
        }

        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
