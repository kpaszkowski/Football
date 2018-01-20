using Football.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Service
{
    class TimetableService
    {
    TicketService ticketService = new TicketService();

    public void AddTimetable(long matchID, long refereeID)
    {
        try
        {
            using (dbEntities1 context = new dbEntities1())
            {
                Match match = context.Match.FirstOrDefault(x => x.id == matchID);
                Referee referee = context.Referee.FirstOrDefault(x => x.id == refereeID);
                Timetable timetable = new Timetable
                {
                    Match = match,
                    Referee = referee
                };
                context.Timetable.Add(timetable);
                context.SaveChanges();
            }
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public bool RemoveTimetable(long ID)
    {
        try
        {
            using (dbEntities1 context = new dbEntities1())
            {
                Timetable timetable = context.Timetable.FirstOrDefault(x => x.id == ID);
                if (!CanRemoveTimetable(timetable))
                {
                    return false;
                }
                context.Timetable.Remove(timetable);
                context.SaveChanges();
                return true;
            }
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    private bool CanRemoveTimetable(Timetable timetable)
    {
        return true;
    }

    internal List<TimetableViewModel> GetAllTimetable()
    {
        try
        {
            using (dbEntities1 context = new dbEntities1())
            {
                List<Timetable> timetableList = context.Timetable.ToList();

                List<TimetableViewModel> list = new List<TimetableViewModel>();

                foreach (Timetable item in timetableList)
                {
                        list.Add(new TimetableViewModel
                        {
                            ID = item.id,
                            MatchID = item.Match.id,
                            RefereeID = item.Referee.id
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

    internal bool EditTimetable(int matchID, int refereeID, long currentTimetableID)
    {
        try
        {
            using (dbEntities1 context = new dbEntities1())
            {
                Timetable timetable = context.Timetable.FirstOrDefault(x => x.id == currentTimetableID);
                timetable.matchID = matchID;
                timetable.refereeID = refereeID;               
                context.Entry(timetable).State = System.Data.Entity.EntityState.Modified;
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
