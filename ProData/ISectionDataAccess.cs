using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProEntity;
namespace ProData
{
    public interface ISectionDataAccess
    {
        IEnumerable<Section> GetAll();
        Section Get(int id);
        List<Section> GetByFaculty(int id);
        List<Section> GetFromStuId(Student St);
        int Insert(Section c);
        int Update(Section admin);
        int setStudent(Section f, List<Student> st);
        int Delete(int id);
        //IEnumerable<Section> GetSecFromCourse();
    }
}
