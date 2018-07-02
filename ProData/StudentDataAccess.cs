using ProEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProData
{
    class StudentDataAccess : IStudentDataAccess
    {
        private VuesDBContext context;

        public StudentDataAccess(VuesDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Student> GetAll()
        {

            return this.context.Student.ToList();

        }

        public Student Get(int id)
        {
            return this.context.Student.SingleOrDefault(x =>x.StuId == id);
        }

        public int Insert(Student stu)
        {
            this.context.Student.Add(stu);
            return this.context.SaveChanges();
        }

        public int Update(Student stu)
        {
            Student s = this.context.Student.SingleOrDefault(x => x.StuId == stu.StuId);
            s.StuPass = stu.StuPass;


            return this.context.SaveChanges();
        }
        public List<Student> GetBySec(int id) {
            List <Student> std= new List<Student>();
            List<Student> allstd = this.context.Student.ToList();
            foreach (var it in allstd) {
                //if(it)
            }


            return std;
        }
        public int Delete(int id)
        {
            Student st = this.context.Student.SingleOrDefault(x => x.StuId == id);
            this.context.Student.Remove(st);

            return this.context.SaveChanges();
        }
    }
}
