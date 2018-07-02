using ProData;
using ProEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProService
{
    class CourseService : ICourseService
    {
        private ICourseDataAccess data;

        public CourseService(ICourseDataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<Course> GetAll()
        {
            return this.data.GetAll();
        }

        public Course Get(int id)
        {
            return this.data.Get(id);
        }
        public List<Course> GetFromSec(List<Section> sec)
        {
            return this.data.GetFromSec(sec);
        }

        public int Insert(Course st)
        {
            return this.data.Insert(st);
        }

        public int Update(Course st)
        {
            return this.data.Update(st);
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }
    }
}
