using ProEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProData
{
    public interface IAdminDataAccess
    {
        IEnumerable<Admin> GetAll();
        Admin Get(int id);
        int Insert(Admin admin);
        int Update(Admin admin);
        int Delete(int id);
    }
}
