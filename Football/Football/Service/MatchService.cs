using Football.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Service
{
    public class MatchService
    {
        TicketService ticketService = new TicketService();

        public void AddMatch(long stadiumID,long hostID,long guestID,long mainReffereID,long technicalReffereID,long linearReffereID,long observerReffereID,int hostGoals,int guestGoals)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    Stadium stadium = context.Stadium.FirstOrDefault(x => x.id == stadiumID);
                    Club hostClub = context.Club.FirstOrDefault(x => x.id == hostID);
                    Club guestClub = context.Club.FirstOrDefault(x => x.id == guestID);
                    Referee mainReffere = context.Referee.FirstOrDefault(x => x.id == mainReffereID);
                    Referee technicalReffere = context.Referee.FirstOrDefault(x => x.id == technicalReffereID);
                    Referee linearReffere = context.Referee.FirstOrDefault(x => x.id == linearReffereID);
                    Referee observerReffere = context.Referee.FirstOrDefault(x => x.id == observerReffereID);
                    Match match = new Match
                    {
                        Stadium=stadium,
                        Club=hostClub,
                        Club1=guestClub,
                        Referee=mainReffere,
                        Referee1=technicalReffere,
                        Referee2=linearReffere,
                        Referee3=observerReffere,
                        hostGoals=hostGoals,
                        guestGoals=guestGoals
                    };
                    context.Match.Add(match);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void AddMatchByTagName(string stadiumName, string hostID, string guestID, string mainReffereID, string technicalReffereID, string linearReffereID, string observerReffereID, int hostGoals, int guestGoals)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    Stadium stadium = context.Stadium.FirstOrDefault(x => x.name == stadiumName);
                    Club hostClub = context.Club.FirstOrDefault(x => x.name == hostID);
                    Club guestClub = context.Club.FirstOrDefault(x => x.name == guestID);
                    Referee mainReffere = context.Referee.FirstOrDefault(x => x.lastName == mainReffereID);
                    Referee technicalReffere = context.Referee.FirstOrDefault(x => x.lastName == technicalReffereID);
                    Referee linearReffere = context.Referee.FirstOrDefault(x => x.lastName == linearReffereID);
                    Referee observerReffere = context.Referee.FirstOrDefault(x => x.lastName == observerReffereID);
                    Match match = new Match
                    {
                        Stadium=stadium,
                        Club = hostClub,
                        Club1 = guestClub,
                        Referee = mainReffere,
                        Referee1 = technicalReffere,
                        Referee2 = linearReffere,
                        Referee3 = observerReffere,
                        hostGoals = hostGoals,
                        guestGoals = guestGoals
                    };
                    context.Match.Add(match);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public bool RemoveMatch(long matchID)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    Match match = context.Match.FirstOrDefault(x => x.id == matchID);
                    if (!CanRemoveMatch(match))//nie posiada graczy ani członków sztabu
                    {
                        return false;
                    }
                    ticketService.RemoveTicketByMatchID(match.id);
                    context.Match.Remove(match);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        private bool CanRemoveMatch(Match match)
        {
            //if (match.Ticket.Count != 0)
            //{
            //    return false;
            //}
            return true;
        }

        internal List<MatchViewModel> GetAllMatches()
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    List<Match> matchesList = context.Match.ToList();

                    List<MatchViewModel> list = new List<MatchViewModel>();

                    foreach (Match item in matchesList)
                    {
                        list.Add(new MatchViewModel {
                            ID = item.id,
                            Stadium_Name=item.Stadium.name,
                            Host_Name=item.Club.name,
                            Guest_Name=item.Club1.name,
                            MainReffere=item.Referee.lastName,
                            TechnicalReffere=item.Referee1.lastName,
                            LinearReffere=item.Referee2.lastName,
                            ObserverReffere=item.Referee3.lastName,
                            HostGoals=item.hostGoals,
                            GuestGoals=item.guestGoals
                        });
                    }

                    return list;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal bool EditMatch(int stadiumID, int hostID, int guestID, int mainRefereeID, int technicalRefereeID, int linearRefereeID, int observerRefereeID, int hostGoals, int guestGoals,int currentMatchID)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    Match match = context.Match.FirstOrDefault(x => x.id == currentMatchID);
                    match.stadiumID = stadiumID;
                    match.hostID = hostID;
                    match.guestID = guestID;
                    match.mainRefereeID = mainRefereeID;
                    match.technicalRefereeID = technicalRefereeID;
                    match.linesRefereeID = linearRefereeID;
                    match.observerRefereeID = observerRefereeID;
                    match.hostGoals = hostGoals;
                    match.guestGoals = guestGoals;
                    context.Entry(match).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
