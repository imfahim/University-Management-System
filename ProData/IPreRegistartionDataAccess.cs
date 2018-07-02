using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProEntity;
namespace ProData
{
    public interface IPreRegistartionDataAccess
    {
        IEnumerable<PreRegistraion> GetAll();
        PreRegistraion Get(int id);
        int Insert(PreRegistraion stu);
        int Update(PreRegistraion stu);
        int Delete(int id);
    }
}
