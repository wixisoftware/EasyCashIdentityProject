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
    public class CustumerAcoountManager : ICustomerAccountServices
    {

        //Dependency ınjection uygulayacağız


        private readonly ICustomerAcoountDAL _customerAcoountDAL;

        public CustumerAcoountManager(ICustomerAcoountDAL customerAcoountDAL)
        {
            _customerAcoountDAL =customerAcoountDAL;
        }
        public void TDelete(CustomerAccount t)
        {
            _customerAcoountDAL.Delete(t);
        }

        public List<CustomerAccount> TGetAll()
        {
          return _customerAcoountDAL.GetAll();
        }

        public CustomerAccount TGetByID(int id)
        {
          return _customerAcoountDAL.GetByID(id);
        }

    

        public void TInsert(CustomerAccount t)
        {
            _customerAcoountDAL.Insert(t);
        }

        public void TUpdate(CustomerAccount t)
        {
            _customerAcoountDAL.Update(t);
        }
    }
}
