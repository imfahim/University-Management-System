using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProData;
using ProEntity;

namespace ProService
{
    class AdminService : IAdminService
    {
        
        private IAdminDataAccess data;

        public AdminService(IAdminDataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<Admin> GetAll()
        {
            return this.data.GetAll();
        }

        public Admin Get(int id)
        {
            return this.data.Get(id);
        }

        public int Insert(Admin admin)
        {
            return this.data.Insert(admin);
        }

        public int Update(Admin admin)
        {
            return this.data.Update(admin);
        }

        public int Delete(int id)
        {
            return this.data.Delete(id);
        }
    }
    }

