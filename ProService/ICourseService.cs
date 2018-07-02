using ProEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProService
{
    public interface ICourseService
    {

        IEnumerable<Course> GetAll();
        Course Get(int id);
        List<Course> GetFromSec(List<Section> sec);
        int Insert(Course c);
        int Update(Course c);
        int Delete(int id);
    }
}
