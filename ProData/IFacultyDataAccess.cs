using ProEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProData
{
    public interface IFacultyDataAccess
    {
        IEnumerable<Faculty> GetAll();
        Faculty Get(int id);
        int Insert(Faculty stu);
        int Update(Faculty stu);
        int Delete(int id);
    }
}
