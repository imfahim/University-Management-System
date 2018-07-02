using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProEntity;

namespace ProData
{
    class AttendenceDataAccess:IAttendenceDataAccess
    {
         private VuesDBContext context;

        public AttendenceDataAccess(VuesDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Attendence> GetAll()
        {

            return this.context.Attendence.ToList();

        }

        public Attendence Get(int id)
        {
            return this.context.Attendence.SingleOrDefault(x => x.AttId == id);
        }

        public int Insert(Attendence f)
        {
            this.context.Attendence.Add(f);
            return this.context.SaveChanges();
        }

        public int Update(Attendence f)
        {
            Attendence ff = this.context.Attendence.SingleOrDefault(x => x.AttId == f.AttId);
            ff.CourseId = f.CourseId;
            ff.StudentId = f.StudentId;
            ff.SecId = f.SecId;
            ff.Date = f.Date;
            ff.Attend = f.Attend;
            ff.AttendCounter = f.AttendCounter;
            return this.context.SaveChanges();
        }

        public int Delete(int id)
        {
            Attendence f = this.context.Attendence.SingleOrDefault(x => x.AttId == id);
            this.context.Attendence.Remove(f);

            return this.context.SaveChanges();
        }
    }
}
