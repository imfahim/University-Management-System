using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProEntity;

namespace ProData
{
    class PreRegistrationDataAccess: IPreRegistartionDataAccess
    {
          private VuesDBContext context;

        public PreRegistrationDataAccess(VuesDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<PreRegistraion > GetAll()
        {

            return this.context.Preregistration.ToList();

        }

        public PreRegistraion Get(int id)
        {
            return this.context.Preregistration.SingleOrDefault(x => x.PreRegId == id);
        }

        public int Insert(PreRegistraion f)
        {
            this.context.Preregistration.Add(f);
            return this.context.SaveChanges();
        }

        public int Update(PreRegistraion f)
        {
            PreRegistraion ff = this.context.Preregistration.SingleOrDefault(x => x.PreRegId == f.PreRegId);
            ff.StudentId = f.StudentId;
            ff.CourseId = f.CourseId;
            ff.SecId= f.SecId;
            ff.Semester = f.Semester;
            ff.TotalCredit = f.TotalCredit;
            return this.context.SaveChanges();
        }

        public int Delete(int id)
        {
            PreRegistraion f = this.context.Preregistration.SingleOrDefault(x => x.PreRegId == id);
            this.context.Preregistration.Remove(f);

            return this.context.SaveChanges();
        }
    }
}
