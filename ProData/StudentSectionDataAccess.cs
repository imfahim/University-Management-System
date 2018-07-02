using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProEntity;

namespace ProData
{
    class StudentSectionDataAccess : IStudentSectionDataAccess
    {
        private VuesDBContext context;

        public StudentSectionDataAccess(VuesDBContext context)
        {
            this.context = context;
        }
        public IEnumerable<StudentSection> GetAll()
        {
            return this.context.StudentSection.ToList();
        }
        public StudentSection Get(int id) {
            return this.context.StudentSection.SingleOrDefault(x => x.StuSec == id);

        }
        public IEnumerable<StudentSection> GetByStu(int id)
        {
            List<StudentSection> stusec = this.context.StudentSection.ToList(); ;
            List<StudentSection> stu = new List<StudentSection>();

            foreach (var it in stusec) {
                if (it.StuId == id) {
                    stu.Add(it);
                }
            }
            return stu;
        }
        public IEnumerable<StudentSection> GetBySec(int id) {
            List<StudentSection> stusec = this.context.StudentSection.ToList(); ;
            List<StudentSection> stu = new List<StudentSection>();

            foreach (var it in stusec)
            {
                if (it.SecId == id)
                {
                    stu.Add(it);
                }
            }
            return stu;
        }
        public int Insert(StudentSection stu) {
            this.context.StudentSection.Add(stu);
            return this.context.SaveChanges();
        }
        public int Update(StudentSection stu) {
            StudentSection ff = this.context.StudentSection.SingleOrDefault(x => x.StuSec == stu.StuSec);
            ff.StuId = stu.StuId;
            ff.SecId = stu.SecId;
            ff.section = stu.section;
            ff.student = stu.student;
            return this.context.SaveChanges();
        }
        public int Delete(int id)
        {
            StudentSection stusec = this.context.StudentSection.SingleOrDefault(x => x.StuSec == id);
            this.context.StudentSection.Remove(stusec);
            return this.context.SaveChanges();

        }
    }
}
