using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Diarymous.Models.Ciphering
{
    public class DefaultCypher : ICiphering
    {
        HashAlgorithm _hashAlgorithm;
        public DefaultCypher(System.Security.Cryptography.HashAlgorithm hashAlgorithm )
        {
            _hashAlgorithm = hashAlgorithm;

        }
        public string generateSaltedString(string password, string salt)
        {
            if(password == null || salt == null)
            {
                return "";
            }
            int periodRate = 2;
            char[] tempPassword = new char[(password.Length + salt.Length / 2)];
            List<char> saltedPassword = new List<char>();

            password.CopyTo(0, tempPassword, 0, password.Length);
            for (int periodCount = 0, saltIndex = 0, i = 0; i < tempPassword.Length; i++)
            {
                periodCount++;

                saltedPassword.Add(tempPassword[i]);
                if (periodCount == periodRate)
                {

                    saltedPassword.Add(salt[saltIndex]);
                    saltIndex++;
                    periodCount = 0;
                }


            }
            return new string(saltedPassword.ToArray());
        }
        public string encrypter(string saltedString)
        {
            var cipher = _hashAlgorithm;
            byte[] bytedString = cipher.ComputeHash(Encoding.ASCII.GetBytes(saltedString));
            var hash = new System.Text.StringBuilder();
            foreach (byte b in bytedString)
            {
                hash.Append(b.ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
