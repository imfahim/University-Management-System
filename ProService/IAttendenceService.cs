using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProEntity;

namespace ProService
{
    public interface IAttendenceService
    {
        IEnumerable<Attendence> GetAll();
        Attendence Get(int id);
        int Insert(Attendence a);
        int Update(Attendence a);
        int Delete(int id);
    }
}
