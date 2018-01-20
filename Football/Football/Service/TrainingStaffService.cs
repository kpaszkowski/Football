using Football.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Service
{
    public class TrainingStaffService
    {
        internal List<TrainingStaffViewModel> GetAllStaff()
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    List<TrainingStaff> trainingStaffList = context.TrainingStaff.ToList();

                    List<TrainingStaffViewModel> list = new List<TrainingStaffViewModel>();

                    foreach (TrainingStaff item in trainingStaffList)
                    {
                        list.Add(new TrainingStaffViewModel { ID = item.id, FirstName = item.firstName, LastName = item.lastName, ClubName = item.Club.name, age=item.age, duty=item.duty });
                    }

                    return list;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal bool AddStaff(string firstName, string lastName, int clubID, int age, string duty)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    TrainingStaff staff = new TrainingStaff
                    {
                        firstName = firstName,
                        lastName = lastName,
                        clubID = clubID,
                        age = age,
                        duty = duty,
                    };
                    context.TrainingStaff.Add(staff);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        internal bool RemoveStaff(int iD)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    TrainingStaff staff = context.TrainingStaff.FirstOrDefault(x => x.id == iD);
                    if (!CanRemoveStaff(staff))
                    {
                        return false;
                    }
                    context.TrainingStaff.Remove(staff);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        private bool CanRemoveStaff(TrainingStaff staff)
        {
            return true;
        }

        internal bool EditStaff(string firstName, string lastName, int clubID, int staffID, int age, string duty)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    TrainingStaff staff = context.TrainingStaff.FirstOrDefault(x => x.id == staffID);
                    staff.firstName = firstName;
                    staff.lastName = lastName;
                    staff.clubID = clubID;
                    staff.age = age;
                    staff.duty = duty;
                    context.Entry(staff).State = System.Data.Entity.EntityState.Modified;
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