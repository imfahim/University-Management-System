using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProEntity;

namespace ProData
{
    public interface IGradeDataAccess
    {
        IEnumerable<Grade> GetAll();
        Grade Get(int id);
        int Insert(Grade admin);
        int Update(Grade ain);
        int Delete(int id);
    }
}
