using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProEntity;
namespace ProService
{
    public interface IReportService
    {
        IEnumerable<Report> GetAll();
        Report Get(int id);
        int Insert(Report n);
        int Update(Report ain);
        int Delete(int id);
    }
}
