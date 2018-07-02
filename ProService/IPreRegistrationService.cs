using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProEntity;

namespace ProService
{
    public interface IPreRegistrationService
    {
        IEnumerable<PreRegistraion> GetAll();
        PreRegistraion Get(int id);
        int Insert(PreRegistraion dm);
        int Update(PreRegistraion adn);
        int Delete(int id);
    }
}
