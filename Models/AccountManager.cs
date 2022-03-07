using Diarymous.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Diarymous.Models
{
    public class AccountManager
    {
        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage ="Kullanıcı Adı Boş Geçilemez")]
        public string username { get; set; }
        [DisplayName("Şifre")]
        [Required(ErrorMessage ="Şifre Boş Geçilemez")]
        public string password { get; set; }
        public static implicit operator Account(AccountManager accountManager){
            return new Account
            {
                password = accountManager.password,
                username = accountManager.username
            };
      }
    }
}
