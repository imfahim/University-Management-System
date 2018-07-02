using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProEntity;

namespace ProData
{
    class GradeDataAccess:IGradeDataAccess
    {
          private VuesDBContext context;

        public GradeDataAccess(VuesDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Grade> GetAll()
        {

            return this.context.Grade.ToList();

        }

        public Grade Get(int id)
        {
            return this.context.Grade.SingleOrDefault(x => x.gradeId == id);
        }

        public int Insert(Grade f)
        {
            this.context.Grade.Add(f);
            return this.context.SaveChanges();
        }

        public int Update(Grade f)
        {
            Grade ff = this.context.Grade .SingleOrDefault(x => x.gradeId == f.gradeId);
            ff.StuId = f.StuId;
            ff.SecId = f.SecId;
            ff.grade = f.grade;

            return this.context.SaveChanges();
        }

        public int Delete(int id)
        {
            Grade f = this.context.Grade.SingleOrDefault(x => x.gradeId == id);
            this.context.Grade.Remove(f);

            return this.context.SaveChanges();
        }
    }
}
