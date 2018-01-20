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
        PlayerService playerService;
        RecordService recordService;
        TimetableService timetableService;
        #endregion

        #region Field

        #region Observable Collections

        public ObservableCollection<StadiumViewModel> stadium { get; set; }
        public ObservableCollection<ClubViewModel> club { get; set; }
        public ObservableCollection<TicketViewModel> ticket { get; set; }
        public ObservableCollection<MatchViewModel> match { get; set; }
        public ObservableCollection<ReffereViewModel> reffere { get; set; }
        public ObservableCollection<PlayerViewModel> player { get; set; }
        public ObservableCollection<RecordViewModel> record { get; set; }
        public ObservableCollection<TimetableViewModel> timetable { get; set; }

        #endregion

        #region Selected Fields

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
        object _SelectedTimetable;
        public object SelectedTimetable
        {
            get
            {
                return _SelectedTimetable;
            }
            set
            {
                if (_SelectedTimetable != value)
                {
                    _SelectedTimetable = value;
                    RaisePropertyChanged("SelectedTimetable");
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
        object _SelectedPlayer;
        public object SelectedPlayer
        {
            get
            {
                return _SelectedPlayer;
            }
            set
            {
                if (_SelectedPlayer != value)
                {
                    _SelectedPlayer = value;
                    RaisePropertyChanged("SelectedPlayer");
                }
            }
        }

        object _SelectedRecord;
        public object SelectedRecord
        {
            get
            {
                return _SelectedRecord;
            }
            set
            {
                if (_SelectedRecord != value)
                {
                    _SelectedRecord = value;
                    RaisePropertyChanged("SelectedRecord");
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

        public RelayCommand AddPlayerCommand { get; set; }
        public RelayCommand RemovePlayerCommand { get; set; }
        public RelayCommand EditPlayerCommand { get; set; }

        public RelayCommand AddRecordCommand { get; set; }
        public RelayCommand RemoveRecordCommand { get; set; }
        public RelayCommand EditRecordCommand { get; set; }

        public RelayCommand AddTimetableCommand { get; set; }
        public RelayCommand RemoveTimetableCommand { get; set; }
        public RelayCommand EditTimetableCommand { get; set; }


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
            UpdateRecordGrid();
            UpdateTimetableGrid();
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
            RecordViewModel recordReferee = (RecordViewModel)values[3];
            reffereService.AddReffere(values[0].ToString(), values[1].ToString(), salary, recordReferee.ID);
            UpdateReffereGrid();
        }

        void EditReferee(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Podaj poprawne dane");
                return;
            }
            var values = (object[])parameter;
            string firstName = values[0].ToString();
            string lastName = values[1].ToString();
            double salary = double.Parse((string)values[2].ToString());
            RecordViewModel currentRecord = (RecordViewModel)values[3];
            ReffereViewModel currentReferee = (ReffereViewModel)values[4];
            if (reffereService.EditReferee(firstName,lastName,salary,currentRecord.ID,currentReferee.ID))
            {
                RefereshAll();
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
            MatchViewModel currentMatch = (MatchViewModel)values[9];
            if (matchService.EditMatch(stadionName.ID,hostName.ID,guestName.ID,mainReffere.ID,technicalReffere.ID,linearReffere.ID,observerReffere.ID,hostGoals,guestGoals,currentMatch.ID))
            {
                RefereshAll();
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
            var values = (object[])parameter;
            int matchTicketID = Int32.Parse(values[0].ToString());
            string PESEL = values[1].ToString();
            TicketViewModel currentTicket = (TicketViewModel)values[2];
            if (ticketService.EditTicket(matchTicketID, PESEL,currentTicket.ID))
            {
                RefereshAll();
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
            var values = (object[])parameter;
            string newName = values[0].ToString();
            string newCity = values[1].ToString();
            string newCountry = values[2].ToString();
            StadiumViewModel currentStadium = (StadiumViewModel)values[3];
            if (stadiumService.EditStadium(newName, newCity, newCountry, currentStadium.ID))
            {
                RefereshAll();
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
            RecordViewModel recordClub = (RecordViewModel)values[2];
            clubService.AddClub(values[0].ToString(), stadiumClub.ID,recordClub.ID);
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
            var values = (object[])parameter;
            string newName = values[0].ToString();
            StadiumViewModel newStadium = (StadiumViewModel)values[1];
            RecordViewModel newRecord = (RecordViewModel)values[2];
            ClubViewModel currentClub = (ClubViewModel)values[3];
            if (clubService.EditClub(newName,newStadium.ID,newRecord.ID,currentClub.ID))
            {
                RefereshAll();
            }
        }

        void UpdateClubGrid()
        {
            var c = clubService.GetAllClub();
            club.Clear();
            foreach (ClubViewModel item in c)
            {
                club.Add(item);
            }
        }
        #endregion

        #region Player

        private void EditPlayer(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Podaj poprawne dane");
                return;
            }
            var values = (object[])parameter;
            string firstName = values[0].ToString();
            string lastName = values[1].ToString();
            ClubViewModel currentClub = (ClubViewModel)values[2];
            RecordViewModel currentRecord = (RecordViewModel)values[3];
            PlayerViewModel currentPlayer = (PlayerViewModel)values[4];
            if (playerService.EditPlayer(firstName, lastName, currentClub.ID,currentRecord.ID,currentPlayer.ID))
            {
                RefereshAll();
            }
        }

        private void RemovePlayer(object parameter)
        {
            if (!ValidateParamsAsObject(parameter))
            {
                ShowInfoWindow("Nie wybrano gracza");
                return;
            }
            PlayerViewModel currentPlayer = (PlayerViewModel)parameter;
            if (playerService.RemovePlayer(currentPlayer.ID))
            {
                RefereshAll();
            }
            else
            {
                ShowInfoWindow("Nie można usunąć gracza");
                return;
            }
        }

        private void AddPlayer(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Podaj poprawne dane");
                return;
            }
            var values = (object[])parameter;
            string firstName = values[0].ToString();
            string lastName = values[1].ToString();
            ClubViewModel currentClub = (ClubViewModel)values[2];
            RecordViewModel currentRecord = (RecordViewModel)values[3];
            if (playerService.AddPlayer(firstName,lastName,currentClub.ID,currentRecord.ID))
            {
                RefereshAll();
            }

        }

        private void UpdatePlayerGrid()
        {
            var p = playerService.GetAllPlayer();
            player.Clear();
            foreach (PlayerViewModel item in p)
            {
                player.Add(item);
            }
        }

        #endregion

        #region Record

        void AddRecord(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Podaj poprawne dane");
                return;
            }
            var values = (object[])parameter;
            Record r = new Record
            {
                type = values[0].ToString(),
                name = values[1].ToString()
            };
            recordService.AddRecord(r);
            UpdateRecordGrid();
        }

        void RemoveRecord(object parameter)//usuwanie po wyszukiwaniu
        {
            if (!ValidateParamsAsObject(parameter))
            {
                ShowInfoWindow("Nie wybrano rekordu");
                return;
            }
            var currentRecord = (RecordViewModel)parameter;
            if (recordService.RemoveRecord(currentRecord.ID))
            {
                UpdateRecordGrid();
            }
            else
            {
                ShowInfoWindow("Nie można usunąć rekordu");
                return;
            }

        }

        void EditRecord(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Podaj poprawne dane");
                return;
            }
            var values = (object[])parameter;
            string newType = values[0].ToString();
            string newName = values[1].ToString();
            RecordViewModel currentRecord = (RecordViewModel)values[2];
            if (recordService.EditRecord(newType, newName, currentRecord.ID))
            {
                RefereshAll();
            }
        }

        void UpdateRecordGrid()//Bieda update , czysci grida i od nowa laduje
        {
            var r = recordService.GetAllRecord();
            record.Clear();
            foreach (Record item in r)
            {
                record.Add(new RecordViewModel { ID = item.id, Type = item.type, Name = item.name });
                //record.Add(item);
            }
        }

        #endregion

        #region Timetable

        private void RemoveTimetable(object parameter)
        {
            if (!ValidateParamsAsObject(parameter))
            {
                ShowInfoWindow("Nie wybrano terminarza");
                return;
            }
            var currentTimetable = (TimetableViewModel)parameter;
            if (timetableService.RemoveTimetable(currentTimetable.ID))
            {
                UpdateTimetableGrid();
            }
            else
            {
                ShowInfoWindow("Nie można usunąć terminarz");
                return;
            }

        }

        private void AddTimetable(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Podaj poprawne dane");
                return;
            }
            var values = (object[])parameter;
            MatchViewModel matchTimetable = (MatchViewModel)values[0];
            ReffereViewModel refereeTimetable = (ReffereViewModel)values[1];
            timetableService.AddTimetable(matchTimetable.ID, refereeTimetable.ID);
            UpdateTimetableGrid();

        }

        void EditTimetable(object parameter)
        {
            if (!ValidateParams(parameter))
            {
                ShowInfoWindow("Podaj poprawne dane");
                return;
            }
            var values = (object[])parameter;
            //int matchTimetable = Int32.Parse(values[0].ToString());
            MatchViewModel currentMatch = (MatchViewModel)values[0];
            //int refereeTimetable = Int32.Parse(values[1].ToString());
            ReffereViewModel currentReferee = (ReffereViewModel)values[1];
            TimetableViewModel currentTimetable = (TimetableViewModel)values[2];
            if (timetableService.EditTimetable(currentMatch.ID, currentReferee.ID, currentTimetable.ID))
            {
                RefereshAll();
            }
        }

        void UpdateTimetableGrid()
        {
            var t = timetableService.GetAllTimetable();
            timetable.Clear();
            foreach (TimetableViewModel item in t)
            {
                timetable.Add(item);
            }
        }
        #endregion

        #region Other

        private void RefereshAll()
        {
            UpdateClubGrid();
            UpdateMatchGrid();
            UpdateReffereGrid();
            UpdateStadiumGrid();
            UpdateTicketGrid();
            UpdatePlayerGrid();
            UpdateRecordGrid();
            UpdateTimetableGrid();
        }

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

            AddPlayerCommand = new RelayCommand(AddPlayer);
            RemovePlayerCommand = new RelayCommand(RemovePlayer);
            EditPlayerCommand = new RelayCommand(EditPlayer);

            AddRecordCommand = new RelayCommand(AddRecord);
            RemoveRecordCommand = new RelayCommand(RemoveRecord);
            EditRecordCommand = new RelayCommand(EditRecord);

            AddTimetableCommand = new RelayCommand(AddTimetable);
            RemoveTimetableCommand = new RelayCommand(RemoveTimetable);
            EditTimetableCommand = new RelayCommand(EditTimetable);

            stadium = new ObservableCollection<StadiumViewModel>();
            club = new ObservableCollection<ClubViewModel>();
            match = new ObservableCollection<MatchViewModel>();
            ticket = new ObservableCollection<TicketViewModel>();
            reffere = new ObservableCollection<ReffereViewModel>();
            player = new ObservableCollection<PlayerViewModel>();
            record = new ObservableCollection<RecordViewModel>();
            timetable = new ObservableCollection<TimetableViewModel>();

            stadiumService = new StadiumService();
            clubService = new ClubService();
            ticketService = new TicketService();
            matchService = new MatchService();
            reffereService = new ReffereService();
            playerService = new PlayerService();
            recordService = new RecordService();
            timetableService = new TimetableService();
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
