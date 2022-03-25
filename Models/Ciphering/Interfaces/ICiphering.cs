using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diarymous.Models
{
    public interface ICiphering
    {
        public string generateSaltedString(string password, string salt); 
        public string encrypter(string saltedString);
    }
}
