using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProEntity;

namespace ProData
{
    class ReportDataAccess: IReportDataAccess
    {
          private VuesDBContext context;

        public ReportDataAccess(VuesDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Report> GetAll()
        {

            return this.context.Report.ToList();

        }

        public Report Get(int id)
        {
            return this.context.Report.SingleOrDefault(x => x.RId == id);
        }

        public int Insert(Report f)
        {
            this.context.Report.Add(f);
            return this.context.SaveChanges();
        }

        public int Update(Report f)
        {
            Report ff = this.context.Report.SingleOrDefault(x => x.RId == f.RId);
            ff.StuId = f.StuId;
            ff.Comment = f.Comment;
            

            return this.context.SaveChanges();
        }

        public int Delete(int id)
        {
            Report f = this.context.Report.SingleOrDefault(x => x.RId == id);
            this.context.Report.Remove(f);

            return this.context.SaveChanges();
        }
    }
}
