using ProEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProService
{
    public interface IFacultyService
    {

        IEnumerable<Faculty> GetAll();
        Faculty Get(int id);
        int Insert(Faculty f);
        int Update(Faculty admin);
        int Delete(int id);
    }
}
