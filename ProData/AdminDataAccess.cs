using ProEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProData
{
    class AdminDataAccess : IAdminDataAccess
    {
        private VuesDBContext context;

        public AdminDataAccess(VuesDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Admin> GetAll()
        {

                return this.context.Admin.ToList();

        }

        public Admin Get(int id)
        {  
                return this.context.Admin.SingleOrDefault(x => x.AdminId == id);
        }

        public int Insert(Admin admin)
        {
            this.context.Admin.Add(admin);
            return this.context.SaveChanges();
        }

        public int Update(Admin admin)
        {
            Admin ad = this.context.Admin.SingleOrDefault(x => x.AdminId == admin.AdminId);
            ad.APassword = admin.APassword;
           

            return this.context.SaveChanges();
        }

        public int Delete(int id)
        {
            Admin ad = this.context.Admin.SingleOrDefault(x => x.AdminId == id);
            this.context.Admin.Remove(ad);

            return this.context.SaveChanges();
        }
    }
}
