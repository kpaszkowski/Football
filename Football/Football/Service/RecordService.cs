using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Service
{
    class RecordService
    {
        public bool AddRecord(Record record)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    context.Record.Add(record);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public bool RemoveRecord(long recordID)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    Record record = context.Record.FirstOrDefault(x => x.id == recordID);

                    if (!CanRemoveRecord(record))
                    {
                        return false;
                    }
                    context.Record.Remove(record);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private bool CanRemoveRecord(Record record)
        {
            if (record.Club.Count != 0)
            {
                return false;
            }
            if (record.Player.Count != 0)
            {
                return false;
            }
            if (record.Referee.Count != 0)
            {
                return false;
            }
            if (record.TrainingStaff.Count != 0)
            {
                return false;
            }
            return true;
        }

        internal List<Record> GetAllRecord()
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    List<Record> record = context.Record.ToList();
                    return record;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal bool EditRecord(string newType, string newName, long currentRecordID)
        {
            try
            {
                using (dbEntities1 context = new dbEntities1())
                {
                    Record record = context.Record.FirstOrDefault(x => x.id == currentRecordID);
                    record.type = newType;
                    record.name = newName;
                    context.Entry(record).State = System.Data.Entity.EntityState.Modified;
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
