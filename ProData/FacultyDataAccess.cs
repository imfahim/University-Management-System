using ProEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProData
{
    class FacultyDataAccess : IFacultyDataAccess
    {
        private VuesDBContext context;

        public FacultyDataAccess(VuesDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Faculty> GetAll()
        {

            return this.context.Faculty.ToList();

        }

        public Faculty Get(int id)
        {
            return this.context.Faculty.SingleOrDefault(x => x.FacultyId == id);
        }

        public int Insert(Faculty f)
        {
            this.context.Faculty.Add(f);
            return this.context.SaveChanges();
        }

        public int Update(Faculty f)
        {
            Faculty ff = this.context.Faculty.SingleOrDefault(x => x.FacultyId == f.FacultyId);
            ff.FacultyPass = f.FacultyPass;
            ff.FacultyName = f.FacultyName;
            ff.Courses = f.Courses;

            return this.context.SaveChanges();
        }

        public int Delete(int id)
        {
            Faculty f = this.context.Faculty.SingleOrDefault(x => x.FacultyId == id);
            this.context.Faculty.Remove(f);

            return this.context.SaveChanges();
        }
    }
}


