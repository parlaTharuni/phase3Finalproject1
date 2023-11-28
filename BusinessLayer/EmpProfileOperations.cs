using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class EmpProfileOperations
    {

        EmpProfileRepository empProfileRepository = new EmpProfileRepository(new EmsContext());

        public void insertEmpProfile(EmpProfile empProfile)
        {
            empProfileRepository.Insert(empProfile);
        }
        public List<EmpProfile> ListOfEmployee()
        {
            return empProfileRepository.GetAll().ToList();
        }
            
           public void updateEmpProfile(EmpProfile empProfile)
        {
             empProfileRepository.Update(empProfile);
            
           
        }
        public void Delete(int empcode)
        {
            empProfileRepository.Delete(empcode);
        }
    }
}
