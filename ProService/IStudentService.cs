using ProEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProService
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAll();
        Student Get(int id);
        int Insert(Student admin);
        int Update(Student admin);

        int Delete(int id);
    }
}
