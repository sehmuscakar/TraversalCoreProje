using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Models
{
    // şifre hata cıktısını türkçeye cevirme model kısmı
    public class CustomIdentityValidator : IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length) //şifre ingilizce hata cıktısını türkçeye çevirme 
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = $"Parola Minimum {length} karekter olmalıdır" // türkçeye cevirme 
            };

        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "Parola en az 1 büyük harf içermelidir"
            };
        }
        public override IdentityError PasswordRequiresLower()
        {

             return new IdentityError()
           {
                Code = "PasswordRequiresLower",
                Description = "Parola en az 1 küçük harf içermelidir"
            };
           }

        public override IdentityError PasswordRequiresNonAlphanumeric() // overide sonra Alp buyle yap otolmatik gelir her komut görevi 
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Parola en az 1 küçük harf içermelidir"
            };
        }
    }
}
