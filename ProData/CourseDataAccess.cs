using ProEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProData
{
    class CourseDataAccess : ICourseDataAccess
    {
        private VuesDBContext context;

        public CourseDataAccess(VuesDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Course> GetAll()
        {

            return this.context.Course.ToList();

        }

        public Course Get(int id)
        {
            return this.context.Course.SingleOrDefault(x => x.CourseId == id);
        }
        public List<Course> GetFromSec(List<Section> sec)
        {
            List<Course> cc = new List<Course>();
            List<Course> cr = this.context.Course.ToList();
            foreach (var c in cr)
            {
                List<Section> scc = this.context.Section.ToList();
                foreach (var s in scc)
                {
                    foreach (var ss in sec)
                    {
                        if (s == ss)
                        {
                            cc.Add(c);
                        }
                    }
                }
            }
            return cc;
        }

        public int Insert(Course f)
        {
            this.context.Course.Add(f);
            return this.context.SaveChanges();
        }

        public int Update(Course f)
        {
            Course ff = this.context.Course.SingleOrDefault(x => x.CourseId == f.CourseId);
            ff.CourseName = f.CourseName;
            ff.Semester = f.Semester;
         
            ff.credit = f.credit;
            return this.context.SaveChanges();
        }

        public int Delete(int id)
        {
            Course f = this.context.Course.SingleOrDefault(x => x.CourseId == id);
            this.context.Course.Remove(f);

            return this.context.SaveChanges();
        }
    }
}
