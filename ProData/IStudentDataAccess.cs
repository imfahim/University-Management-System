using ProEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProData
{
    public interface IStudentDataAccess
    {
        IEnumerable<Student> GetAll();
        Student Get(int id);
        int Insert(Student stu);
        int Update(Student stu);
        int Delete(int id);
        List<Student> GetBySec(int id);
    }
}
