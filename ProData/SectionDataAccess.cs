using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProEntity;

namespace ProData
{
    class SectionDataAccess: ISectionDataAccess
    {
          private VuesDBContext context;

        public SectionDataAccess(VuesDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Section> GetAll()
        {

            return this.context.Section.ToList();

        }
        //public IEnumerable<Section> GetSecFromCourse(Course cr) {
        //    return this.context.Section.SingleOrDefault(x => x.course == cr).;

        //}
        public List<Section> GetFromStuId(Student St)
        {
            List<Section> ss = new List<Section>();
            List<Section> Sec = this.context.Section.ToList();
            foreach (var s in Sec)
            {
                if (s != null)
                {

                    List<Student> stt = this.context.Student.ToList();
                    foreach (var Stu in stt)
                    {
                        if (Stu == St)
                        {
                            ss.Add(s);
                        }

                    }
                }

            }
            return ss;
        }

        public Section Get(int id)
        {
            return this.context.Section.SingleOrDefault(x => x.SecId == id);
        }
        public List<Section> GetByFaculty(int id) 
        {
            List<Section> sec = new List<Section>();
            List<Section> ss = this.context.Section.ToList();
            foreach (var s in ss)
            {
                if (s.FacultyId == id) {
                    sec.Add(s);
                }
            }
            return sec;

        }

        public int Insert(Section f)
        {
            this.context.Section.Add(f);
            return this.context.SaveChanges();
        }

        public int Update(Section f)
        {
            Section ff = this.context.Section.SingleOrDefault(x => x.SecId == f.SecId);
            ff.SecName= f.SecName;
            ff.faculty.FacultyId = f.faculty.FacultyId;
            ff.student = f.student;
            ff.CourseId = f.CourseId;
            ff.course.CourseId = f.course.CourseId;
            ff.student = f.student;

            return this.context.SaveChanges();
        }
        public int setStudent(Section f, List<Student> st) {
            Section ff = this.context.Section.SingleOrDefault(x => x.SecId == f.SecId);
            ff.student = st;
            return this.context.SaveChanges();
        }

        public int Delete(int id)
        {
            Section f = this.context.Section.SingleOrDefault(x => x.SecId == id);
            this.context.Section.Remove(f);
            return this.context.SaveChanges();
        }
    }
}
