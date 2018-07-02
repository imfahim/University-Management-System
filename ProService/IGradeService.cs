using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProEntity;

namespace ProService
{
    public interface  IGradeService
    {
        IEnumerable<Grade > GetAll();
        Grade  Get(int id);
        int Insert(Grade  admin);
        int Update(Grade  ad);
        int Delete(int id);
    }
}
