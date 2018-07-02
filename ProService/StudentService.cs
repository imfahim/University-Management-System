using ProData;
using ProEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProService
{
    class StudentService : IStudentService
    {
        private IStudentDataAccess data;

        public StudentService(IStudentDataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<Student> GetAll()
        {
            return this.data.GetAll();
        }

        public Student Get(int id)
        {
            return this.data.Get(id);
        }

        public int Insert(Student st)
        {
            return this.data.Insert(st);
        }

        public int Update(Student st)
        {
            return this.data.Update(st);
        }
        
        public int Delete(int id)
        {
            return this.data.Delete(id);
        }
    }
}
