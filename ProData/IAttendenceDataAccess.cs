using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProEntity;

namespace ProData
{
    public interface IAttendenceDataAccess
    {
        IEnumerable<Attendence> GetAll();
        Attendence Get(int id);
        int Insert(Attendence attendence);
        int Update(Attendence attendence);
        int Delete(int id);
    }
}
