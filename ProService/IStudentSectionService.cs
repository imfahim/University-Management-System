using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProEntity;

namespace ProService
{
    public interface IStudentSectionService
    {
        IEnumerable<StudentSection> GetAll();
        StudentSection Get(int id);
        IEnumerable<StudentSection> GetByStu(int id);
        IEnumerable<StudentSection> GetBySec(int id);
        int Insert(StudentSection stu);
        int Update(StudentSection stu);
        int Delete(int id);
    }
}
