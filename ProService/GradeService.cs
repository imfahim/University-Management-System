using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProData;
using ProEntity;

namespace ProService
{
    class GradeService: IGradeService 
    {
          private IGradeDataAccess data;

        public GradeService(IGradeDataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<Grade> GetAll()
        {
            return this.data.GetAll();
        }

        public Grade Get(int id)
        {
            return this.data.Get(id);
        }

        public int Insert(Grade st)
        {
            return this.data.Insert(st);
        }

        public int Update(Grade st)
        {
            return this.data.Update(st);
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }
    }
}
