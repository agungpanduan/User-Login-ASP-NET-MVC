using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace UserLogin.Models
{
    public static class encryptPassword
    {
        public static string textToEncrypt(string paasWord)
        {
            return Convert.ToBase64String(System.Security.Cryptography.SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(paasWord)));
        }
    }  
}