using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProEntity;
using ProData;

namespace ProService
{
    public class StudentSectionService : IStudentSectionService
    {
        private IStudentSectionDataAccess data;

        public StudentSectionService(IStudentSectionDataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<StudentSection> GetAll() {
            return this.data.GetAll();
        }
        public StudentSection Get(int id) {
            return this.data.Get(id);
        }
        public IEnumerable<StudentSection> GetByStu(int id) {
            return this.data.GetByStu(id);

        }
        public IEnumerable<StudentSection> GetBySec(int id) {
            return this.data.GetBySec(id);
        }
        public int Insert(StudentSection stu) {
            return this.data.Insert(stu);

        }
        public int Update(StudentSection stu) {
            return this.data.Update(stu);

        }
        public int Delete(int id) {
            return this.data.Delete(id);

        }
    }
}
