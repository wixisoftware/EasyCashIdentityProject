using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DTOLayer.Dtos.AppUserDtos
{
    public class AppUserRegisterDto
    {
        //Validasyon vermek için bu yöntemi kullanmayacağız
        //[Required(ErrorMessage ="Ad alanı zorunludur")]
        //[Display(Name= "İsim:")]
        //[MaxLength(50)]
        //  public string Name { get; set; }


        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

    }

    // Ad,Soyad,username,mail,password,confirmpassword 
}
