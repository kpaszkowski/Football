﻿using Football.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Service
{
    public class ReffereService
    {
        public void AddReffere(string firstName,string lastName,double salary, int recordID)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    Referee referee = new Referee
                    {
                        firstName = firstName,
                        lastName = lastName,
                        salary=salary,
                        recordID=recordID
                    };
                    context.Referee.Add(referee);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public bool RemoveReffere(long reffereID)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    Referee referee = context.Referee.FirstOrDefault(x => x.id == reffereID);
                    if (!CanRemoveReffere(referee))
                    {
                        return false;
                    }
                    context.Referee.Remove(referee);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        private bool CanRemoveReffere(Referee referee)
        {
            if (referee.Match.Count != 0)
            {
                return false;
            }
            if (referee.Match1.Count != 0)
            {
                return false;
            }
            if (referee.Match2.Count != 0)
            {
                return false;
            }
            if (referee.Match3.Count != 0)
            {
                return false;
            }
            return true;
        }
        internal List<ReffereViewModel> GetAllReffere()
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    List<Referee> reffereList = context.Referee.ToList();

                    List<ReffereViewModel> list = new List<ReffereViewModel>();

                    foreach (Referee item in reffereList)
                    {
                        list.Add(new ReffereViewModel { ID = item.id,FirstName=item.firstName,LastName=item.lastName,Salary=item.salary, RecordID = item.Record != null ? item.Record.id : 0 });
                    }

                    return list;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal bool EditReferee(string firstName, string lastName, double salary, int recordID, int iD)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    Referee referee = context.Referee.FirstOrDefault(x => x.id == iD);
                    referee.firstName = firstName;
                    referee.lastName = lastName;
                    referee.salary = salary;
                    referee.recordID = recordID;
                    context.Entry(referee).State = System.Data.Entity.EntityState.Modified;
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
