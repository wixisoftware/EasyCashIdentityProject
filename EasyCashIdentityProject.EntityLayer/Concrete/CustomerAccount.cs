using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class CustomerAccount
    {

        public int CustomerAccountID { get; set; }
        // Sınıf isminin sonuna ID ile eklenilir ise birincil anahtar olması gerektiğini otomatik olarak anlar.

        public string CustomerAccountNumber { get; set; }     

        public string CustomerAccountCurrency { get; set;}  // birimi nedir.

        public decimal CustomerAccountBalance{ get; set; }  // müşterinin hesabındaki parayı tutar.
                                                            
        public string CustomerAccountBankBranch { get; set; } // Şube bilgisi


        //Bire çok ilişki oluşturduk
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }

    }
}
