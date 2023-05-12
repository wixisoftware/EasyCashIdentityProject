using EasyCashIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.Abstract
{
    public interface ICustomerAccountServices:IGenericServices<CustomerAccount> 
    {
        // Temel metotların haricinde özel bir metot var ise buraya yazılıcak
    }
}
