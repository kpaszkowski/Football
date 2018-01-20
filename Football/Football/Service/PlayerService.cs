using Football.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Service
{
    public class PlayerService
    {
        internal List<PlayerViewModel> GetAllPlayer()
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    List<Player> playerList = context.Player.ToList();

                    List<PlayerViewModel> list = new List<PlayerViewModel>();

                    foreach (Player item in playerList)
                    {
                        list.Add(new PlayerViewModel { ID = item.id, FirstName = item.firstName, LastName = item.lastName,ClubName=item.Club.name, RecordID = item.Record != null ? item.Record.id : 0 });
                    }

                    return list;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal bool AddPlayer(string firstName, string lastName, int clubID, int recordID)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    Player player = new Player
                    {
                        firstName = firstName,
                        lastName = lastName,
                        clubID=clubID,
                        recordID=recordID
                    };
                    context.Player.Add(player);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        internal bool RemovePlayer(int iD)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    Player player = context.Player.FirstOrDefault(x => x.id == iD);
                    if (!CanRemovePlayer(player))
                    {
                        return false;
                    }
                    context.Player.Remove(player);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        private bool CanRemovePlayer(Player player)
        {
            return true;
        }

        internal bool EditPlayer(string firstName, string lastName, int clubID, int recordID, int playerID)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    Player player = context.Player.FirstOrDefault(x => x.id == playerID);
                    player.firstName = firstName;
                    player.lastName = lastName;
                    player.clubID = clubID;
                    player.recordID = recordID;
                    context.Entry(player).State = System.Data.Entity.EntityState.Modified;
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
