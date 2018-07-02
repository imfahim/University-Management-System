using ProData;
using ProEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProService
{
    class FacultyService : IFacultyService
    {
        private IFacultyDataAccess data;

        public FacultyService(IFacultyDataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<Faculty> GetAll()
        {
            return this.data.GetAll();
        }

        public Faculty Get(int id)
        {
            return this.data.Get(id);
        }

        public int Insert(Faculty st)
        {
            return this.data.Insert(st);
        }

        public int Update(Faculty st)
        {
            return this.data.Update(st);
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }
    }
}

