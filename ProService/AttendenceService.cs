using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProData;
using ProEntity;

namespace ProService
{
    class AttendenceService:IAttendenceService
    {
          private IAttendenceDataAccess data;

        public AttendenceService(IAttendenceDataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<Attendence> GetAll()
        {
            return this.data.GetAll();
        }

        public Attendence Get(int id)
        {
            return this.data.Get(id);
        }

        public int Insert(Attendence at)
        {
            return this.data.Insert(at);
        }

        public int Update(Attendence st)
        {
            return this.data.Update(st);
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }
    }
}
