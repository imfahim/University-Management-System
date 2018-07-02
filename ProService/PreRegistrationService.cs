using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProData;
using ProEntity;

namespace ProService
{
    class PreRegistrationService :IPreRegistrationService
    {
          private IPreRegistartionDataAccess data;

        public PreRegistrationService(IPreRegistartionDataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<PreRegistraion> GetAll()
        {
            return this.data.GetAll();
        }

        public PreRegistraion Get(int id)
        {
            return this.data.Get(id);
        }

        public int Insert(PreRegistraion st)
        {
            return this.data.Insert(st);
        }

        public int Update(PreRegistraion st)
        {
            return this.data.Update(st);
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }
    }
}
