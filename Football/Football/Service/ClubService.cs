using Football.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class ClubService
    {
        //public void AddClub(string name, Stadium stadium)
        //{
        //    try
        //    {
        //        using (dbEntities1 context = new dbEntities1())
        //        {
        //            Club club = new Club
        //            {
        //                name = name,
        //            };
        //            if (stadium!=null)
        //            {
        //                club.Stadium = stadium;
        //            }
        //            context.Club.Add(club);
        //            context.SaveChanges();
        //        }
        //    }
        //    catch (Exception e)
        //    {

        //        throw e;
        //    }
        //}

        public void AddClub(string name, long stadiumID, long recordID)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    Stadium stadium = context.Stadium.FirstOrDefault(x => x.id == stadiumID);
                    Record record = context.Record.FirstOrDefault(x => x.id == recordID);
                    Club club = new Club
                    {
                        name = name,
                        Stadium = stadium,
                        Record = record
                    };
                    context.Club.Add(club);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public bool RemoveClub(int clubID)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    Club club = context.Club.FirstOrDefault(x => x.id==clubID);
                    if (!CanRemoveClub(club))//nie posiada graczy ani członków sztabu
                    {
                        return false;
                    }
                    context.Club.Remove(club);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        private bool CanRemoveClub(Club club)
        {
            if (club.Player.Count!=0)
            {
                return false;
            }
            if (club.TrainingStaff.Count!=0)
            {
                return false;
            }
            if (club.Match.Count!=0)
            {
                return false;
            }
            if (club.Match1.Count != 0)
            {
                return false;
            }
            return true;
        }

        internal List<ClubViewModel> GetAllClub()
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    List<Club> clubList = context.Club.ToList();

                    List<ClubViewModel> list = new List<ClubViewModel>();

                    foreach (Club item in clubList)
                    {
                        list.Add(new ClubViewModel { ID = item.id, Name = item.name, Stadium_Name = item.Stadium!=null? item.Stadium.name:String.Empty, RecordID = item.Record!=null? item.Record.id:0 });
                    }

                    return list;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal bool EditClub(string newName, int newStadiumID, int newRecordID, long oldClubID)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    Club club = context.Club.FirstOrDefault(x => x.id == oldClubID);
                    club.name = newName;
                    club.stadiumID = newStadiumID;
                    club.recordID = newRecordID;
                    context.Entry(club).State = System.Data.Entity.EntityState.Modified;
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
