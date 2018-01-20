using Football.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Service
{
    public class WinnersService
    {
        internal List<WinnersViewModel> GetAllWinners()
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    List<Winners> winnersList = context.Winners.ToList();

                    List<WinnersViewModel> list = new List<WinnersViewModel>();

                    foreach (Winners item in winnersList)
                    {
                        list.Add(new WinnersViewModel { ID = item.id, year= item.year, clubID= item.Club.id, wonMatches = item.wonMatches, lostMatches = item.lostMatches, goalsScored = item.goalsScored, goalsLost = item.goalsLost });
                    }

                    return list;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal bool AddWinners(int clubID, string year, int wonMatches, int lostMatches, int goalsScored, int goalsLost)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    Winners winners = new Winners
                    {
                        clubID = clubID,
                        year = year,
                        wonMatches = wonMatches,
                        lostMatches = lostMatches,
                        goalsScored = goalsScored,
                        goalsLost = goalsLost
                    };
                    context.Winners.Add(winners);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        internal bool RemoveWinners(int iD)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    Winners winners = context.Winners.FirstOrDefault(x => x.id == iD);
                    if (!CanRemoveWinners(winners))
                    {
                        return false;
                    }
                    context.Winners.Remove(winners);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        private bool CanRemoveWinners(Winners winners)
        {
            return true;
        }

        internal bool EditWinners(int clubID, string year, int wonMatches, int lostMatches, int goalsScored, int goalsLost, int winnersID)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    Winners winners = context.Winners.FirstOrDefault(x => x.id == winnersID);
                    winners.goalsScored = goalsScored;
                    winners.goalsLost = goalsLost;
                    winners.lostMatches = lostMatches;
                    winners.clubID = clubID;
                    winners.wonMatches = wonMatches;
                    winners.lostMatches = lostMatches;
                    winners.year = year;
                    context.Entry(winners).State = System.Data.Entity.EntityState.Modified;
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