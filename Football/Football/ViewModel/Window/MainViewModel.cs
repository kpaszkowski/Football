using Football.Commands;
using Football.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.ViewModel.Window
{
    public class MainViewModel : BaseViewModel
    {
        #region Service
        StadiumService stadiumService;
        ClubService clubService;
        TicketService ticketService;
        MatchService matchService;
        ReffereService reffereService;
        #endregion

        #region Field

        #region Observable Collections

        public ObservableCollection<StadiumViewModel> stadium { get; set; }
        public ObservableCollection<ClubViewModel> club { get; set; }
        public ObservableCollection<TicketViewModel> ticket { get; set; }
        public ObservableCollection<MatchViewModel> match { get; set; }
        public ObservableCollection<ReffereViewModel> reffere { get; set; }

        #endregion

        #region Selected FIelds

        object _SelectedStadium;
        public object SelectedStadium
        {
            get
            {
                return _SelectedStadium;
            }
            set
            {
                if (_SelectedStadium != value)
                {
                    _SelectedStadium = value;
                    RaisePropertyChanged("SelectedStadium");
                }
            }
        }
        object _SelectedClub;
        public object SelectedClub
        {
            get
            {
                return _SelectedClub;
            }
            set
            {
                if (_SelectedClub != value)
                {
                    _SelectedClub = value;
                    RaisePropertyChanged("SelectedClub");
                }
            }
        }
        object _SelectedClub2;
        public object SelectedClub2
        {
            get
            {
                return _SelectedClub2;
            }
            set
            {
                if (_SelectedClub2 != value)
                {
                    _SelectedClub2 = value;
                    RaisePropertyChanged("SelectedClub2");
                }
            }
        }
        object _SelectedMatch;
        public object SelectedMatch
        {
            get
            {
                return _SelectedMatch;
            }
            set
            {
                if(_SelectedMatch != value)
                {
                    _SelectedMatch = value;
                    RaisePropertyChanged("SelectedMatch");
                }
            }
        }
        object _SelectedTicket;
        public object SelectedTicket
        {
            get
            {
                return _SelectedTicket;
            }
            set
            {
                if(_SelectedTicket != value)
                {
                    _SelectedTicket = value;
                    RaisePropertyChanged("SelectedTicket");
                }
            }
        }
        object _SelectedReffere;
        public object SelectedReffere
        {
            get
            {
                return _SelectedReffere;
            }
            set
            {
                if (_SelectedReffere != value)
                {
                    _SelectedReffere = value;
                    RaisePropertyChanged("SelectedReffere");
                }
            }
        }
        object _SelectedReffere2;
        public object SelectedReffere2
        {
            get
            {
                return _SelectedReffere2;
            }
            set
            {
                if (_SelectedReffere2 != value)
                {
                    _SelectedReffere2 = value;
                    RaisePropertyChanged("SelectedReffere2");
                }
            }
        }
        object _SelectedReffere3;
        public object SelectedReffere3
        {
            get
            {
                return _SelectedReffere3;
            }
            set
            {
                if (_SelectedReffere3 != value)
                {
                    _SelectedReffere3 = value;
                    RaisePropertyChanged("SelectedReffere3");
                }
            }
        }
        object _SelectedReffere4;
        public object SelectedReffere4
        {
            get
            {
                return _SelectedReffere4;
            }
            set
            {
                if (_SelectedReffere4 != value)
                {
                    _SelectedReffere4 = value;
                    RaisePropertyChanged("SelectedReffere4");
                }
            }
        }

        #endregion

        #region Relay Command

        public RelayCommand AddStadiumCommand { get; set; }
        public RelayCommand RemoveStadiumCommand { get; set; }
        public RelayCommand EditStadiumCommand { get; set; }

        public RelayCommand AddMatchCommand { get; set; }
        public RelayCommand RemoveMatchCommand { get; set; }
        public RelayCommand EditMatchCommand { get; set; }

        public RelayCommand AddTicketCommand { get; set; }
        public RelayCommand RemoveTicketCommand { get; set; }
        public RelayCommand EditTicketCommand { get; set; }

        public RelayCommand AddClubCommand { get; set; }
        public RelayCommand RemoveClubCommand { get; set; }
        public RelayCommand EditClubCommand { get; set; }

        public RelayCommand AddReffereCommand { get; set; }
        public RelayCommand RemoveReffereCommand { get; set; }
        public RelayCommand EditReffereCommand { get; set; }


        #endregion

        #endregion

        public MainViewModel()
        {
            InitializeCommands();
            UpdateStadiumGrid();
            UpdateClubGrid();
            UpdateReffereGrid();
            UpdateMatchGrid();
            UpdateTicketGrid();
        }

        #region Reffere

        private void RemoveReffere(object parameter)
        {
            if (!ValidateParamsAsObject(parameter))
            {
                ShowInfoWindow("Nie wybrano sedziego");
                return;
            }
            var values = (ReffereViewModel)parameter;
            if (reffereService.RemoveReffere(values.ID))
            {
                UpdateReffereGrid();
            }
            else
            {
                ShowInfoWindow("Nie można usunąć sędziego");
                return;
            }
        }

        private void AddReffere(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Podaj poprawne dane");
                return;
            }
            var values = (object[])parameter;
            double salary = double.Parse((string)values[2].ToString());
            reffereService.AddReffere(values[0].ToString(), values[1].ToString(), salary);
            UpdateReffereGrid();
        }

        void EditReferee(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Podaj poprawne dane");
                return;
            }
        }

        void UpdateReffereGrid()//Bieda update , czysci grida i od nowa laduje
        {
            var r = reffereService.GetAllReffere();
            reffere.Clear();
            foreach (ReffereViewModel item in r)
            {
                reffere.Add(item);
            }
        }

        #endregion

        #region Match

        private void RemoveMatch(object parameter)
        {
            if (!ValidateParamsAsObject(parameter))
            {
                ShowInfoWindow("Nie wybrano meczu");
                return;
            }
            var values = (MatchViewModel)parameter;
            if (matchService.RemoveMatch(values.ID))
            {
                UpdateMatchGrid();
                UpdateTicketGrid();
            }
            else
            {
                ShowInfoWindow("Nie można usunać meczu");
                return;
            }
        }

        private void AddMatch(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Podaj poprawne dane");
                return;
            }
            var values = (object[])parameter;

            StadiumViewModel stadionName = (StadiumViewModel)values[0];
            ClubViewModel hostName = (ClubViewModel)values[1];
            ClubViewModel guestName = (ClubViewModel)values[2];
            ReffereViewModel mainReffere = (ReffereViewModel)values[3];
            ReffereViewModel technicalReffere = (ReffereViewModel)values[4];
            ReffereViewModel linearReffere = (ReffereViewModel)values[5];
            ReffereViewModel observerReffere = (ReffereViewModel)values[6];
            int hostGoals = Int32.Parse((string)values[7].ToString());
            int guestGoals = Int32.Parse((string)values[8].ToString());

            matchService.AddMatch(stadionName.ID, hostName.ID, guestName.ID, mainReffere.ID, technicalReffere.ID, linearReffere.ID, observerReffere.ID, hostGoals, guestGoals);
            UpdateMatchGrid();
        }

        void EditMatch(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Podaj poprawne dane");
                return;
            }
        }

        void UpdateMatchGrid()//Bieda update , czysci grida i od nowa laduje
        {
            var m = matchService.GetAllMatches();
            match.Clear();
            foreach (MatchViewModel item in m)
            {
                match.Add(item);
            }
        }
        #endregion

        #region Ticket

        private void RemoveTicket(object parameter)
        {
            if (!ValidateParamsAsObject(parameter))
            {
                ShowInfoWindow("Nie wybrano biletu");
                return;
            }
            var currentTicket = (TicketViewModel)parameter;
            if (ticketService.RemoveTicket(currentTicket.ID))
            {
                UpdateTicketGrid();
            }
            else
            {
                ShowInfoWindow("Nie można usunąć biletu");
                return;
            }

        }

        private void AddTicket(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Podaj poprawne dane");
                return;
            }
            var values = (object[])parameter;
            MatchViewModel matchTicket = (MatchViewModel)values[0];
            string PESEL = values[1].ToString();
            var date = (Nullable<DateTime>)values[2];
            ticketService.AddTicket(PESEL, matchTicket.ID, date.Value.ToShortDateString());
            UpdateTicketGrid();
            
        }

        void EditTicket(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Podaj poprawne dane");
                return;
            }
        }

        void UpdateTicketGrid()//Bieda update , czysci grida i od nowa laduje
        {
            var t = ticketService.GetAllTicket();
            ticket.Clear();
            foreach (TicketViewModel item in t)
            {
                ticket.Add(item);
            }
        }
        #endregion

        #region Stadium

        void AddStadium(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Podaj poprawne dane");
                return;
            }
            var values = (object[])parameter;
            Stadium s = new Stadium
            {
                name = values[0].ToString(),
                city = values[1].ToString(),
                country = values[2].ToString()
            };
            stadiumService.AddStadium(s);
            UpdateStadiumGrid();
        }

        void RemoveStadium(object parameter)//usuwanie po wyszukiwaniu
        {
            if (!ValidateParamsAsObject(parameter))
            {
                ShowInfoWindow("Nie wybrano stadionu");
                return;
            }
            var currentStadium = (StadiumViewModel)parameter;
            if (stadiumService.RemoveStadium(currentStadium.ID))
            {
                UpdateStadiumGrid();
            }
            else
            {
                ShowInfoWindow("Nie można usunąć stadionu");
                return;
            }

        }

        void EditStadium(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Podaj poprawne dane");
                return;
            }
        }

        void UpdateStadiumGrid()//Bieda update , czysci grida i od nowa laduje
        {
            var s = stadiumService.GetAllStadium();
            stadium.Clear();
            foreach (Stadium item in s)
            {
                stadium.Add(new StadiumViewModel {ID=item.id, Name = item.name, City = item.city, Country = item.country });
            }
        }

        #endregion

        #region Club

        void AddClub(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Podaj poprawne dane");
                return;
            }
            var values = (object[])parameter;
            StadiumViewModel stadiumClub=(StadiumViewModel)values[1];
            clubService.AddClub(values[0].ToString(), stadiumClub.ID);
            UpdateClubGrid();

        }

        void RemoveClub(object parameter)
        {
            if (!ValidateParamsAsObject(parameter))
            {
                ShowInfoWindow("Nie wybrano klubu");
                return;
            }
            var values = (ClubViewModel)parameter;
            if (clubService.RemoveClub(values.ID))
            {
                UpdateClubGrid();
            }
            else
            {
                ShowInfoWindow("Nie można usunąć klubu");
                return;
            }
        }

        void EditClub(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Podaj poprawne dane");
                return;
            }
        }

        void UpdateClubGrid()//Bieda update , czysci grida i od nowa laduje
        {
            var c = clubService.GetAllClub();
            club.Clear();
            foreach (ClubViewModel item in c)
            {
                club.Add(item);
            }
        }
        #endregion

        #region Other

        private void InitializeCommands()
        {
            AddStadiumCommand = new RelayCommand(AddStadium);
            RemoveStadiumCommand = new RelayCommand(RemoveStadium);
            EditStadiumCommand = new RelayCommand(EditStadium);

            AddClubCommand = new RelayCommand(AddClub);
            RemoveClubCommand = new RelayCommand(RemoveClub);
            EditClubCommand = new RelayCommand(EditClub);

            AddTicketCommand = new RelayCommand(AddTicket);
            RemoveTicketCommand = new RelayCommand(RemoveTicket);
            EditTicketCommand = new RelayCommand(EditTicket);

            AddMatchCommand = new RelayCommand(AddMatch);
            RemoveMatchCommand = new RelayCommand(RemoveMatch);
            EditMatchCommand = new RelayCommand(EditMatch);

            AddReffereCommand = new RelayCommand(AddReffere);
            RemoveReffereCommand = new RelayCommand(RemoveReffere);
            EditReffereCommand = new RelayCommand(EditReferee);


            stadium = new ObservableCollection<StadiumViewModel>();
            club = new ObservableCollection<ClubViewModel>();
            match = new ObservableCollection<MatchViewModel>();
            ticket = new ObservableCollection<TicketViewModel>();
            reffere = new ObservableCollection<ReffereViewModel>();

            stadiumService = new StadiumService();
            clubService = new ClubService();
            ticketService = new TicketService();
            matchService = new MatchService();
            reffereService = new ReffereService();
        }

        public void ShowInfoWindow(string info)
        {
            AlertWindow infoWindow = new AlertWindow(info);
            infoWindow.ShowDialog();
        }

        public bool ValidateParams(object parameter)
        {
            if (parameter == null)
            {
                return false;
            }
            var values = (object[])parameter;
            foreach (var item in values)
            {
                if (item == null)
                {
                    return false;
                }
                if (item as String == string.Empty)
                {
                    return false;
                }
            }
            return true;
        }

        public bool ValidateParamsAsObject(object parameter)
        {
            if (parameter == null)
            {
                return false;
            }
            return true;
        }

        #endregion
    }
}
