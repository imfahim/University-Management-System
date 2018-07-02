using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProEntity;
using ProData;

namespace ProService
{
    class ReportService:IReportService
    {
          private IReportDataAccess data;

        public ReportService(IReportDataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<Report> GetAll()
        {
            return this.data.GetAll();
        }

        public Report Get(int id)
        {
            return this.data.Get(id);
        }

        public int Insert(Report min)
        {
            return this.data.Insert(min);
        }

        public int Update(Report admin)
        {
            return this.data.Update(admin);
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }
    }
}
