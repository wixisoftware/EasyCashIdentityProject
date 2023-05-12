using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Abstract;
using EasyCashIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.Concrete
{
    public class CustomerAccountProcessManager : ICustomerAccountProcessServices
    {
        // readonly parametresi ne işe yarar : const gibi sabit bir değişken olarak kullanmamıza olanak tanır  fakat object diziler için bu işlemi gerrçekleştiri.
        private readonly ICustomerAccountProcessDAL _customerAccountProcessDAL;

        public CustomerAccountProcessManager(ICustomerAccountProcessDAL customerAccountProcessDAL)
        {
            // burda yukarıdan yani UI da çağırılırken bir göndeirm sağlıyıp zorululuklaır kaldırmış olucağız.
            _customerAccountProcessDAL = customerAccountProcessDAL;
            
        }
        public void TDelete(CustomerAccountProcess t)
        {
            _customerAccountProcessDAL.Delete(t);
        }

        public List<CustomerAccountProcess> TGetAll()
        {
            return _customerAccountProcessDAL.GetAll();
        }

        public CustomerAccountProcess TGetByID(int id)
        {
            return _customerAccountProcessDAL.GetByID(id);
        }

        public void TInsert(CustomerAccountProcess t)
        {
            _customerAccountProcessDAL.Insert(t);
        }

        public void TUpdate(CustomerAccountProcess t)
        {
            _customerAccountProcessDAL.Update(t);
        }
    }
}
