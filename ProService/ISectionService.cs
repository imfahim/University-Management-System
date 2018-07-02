using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProEntity;
namespace ProService
{
    public interface ISectionService
    {
        IEnumerable<Section> GetAll();
        Section Get(int id);

        List<Section> GetByFaculty(int id);
        List<Section> GetFromStuId(Student stu);
        int Insert(Section f);
        int Update(Section min);
        int setStudent(Section f, List<Student> st);
        int Delete(int id);
    }
}
