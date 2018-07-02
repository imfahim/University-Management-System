using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProEntity;
using ProData;

namespace ProService
{
    class SectionService:ISectionService
    {
          private ISectionDataAccess data;

        public SectionService(ISectionDataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<Section> GetAll()
        {
            return this.data.GetAll();
        }
        public List<Section> GetFromStuId(Student stu)
        {
            return this.data.GetFromStuId(stu);
        }
        public Section Get(int id)
        {
            return this.data.Get(id);
        }
        public List<Section> GetByFaculty(int id)
        {
            return this.data.GetByFaculty(id);
        }

        public int Insert(Section st)
        {
            return this.data.Insert(st);
        }

        public int Update(Section st)
        {
            return this.data.Update(st);
        }
        public int setStudent(Section f, List<Student> st) {
            return this.data.setStudent(f, st);
        }
        public int Delete(int id)
        {
            return this.data.Delete(id);
        }
    }
}
