using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProEntity;

namespace ProData
{
    public interface IReportDataAccess
    {
        IEnumerable<Report> GetAll();
        Report Get(int id);
        int Insert(Report stu);
        int Update(Report stu);
        int Delete(int id);

    }
}
