using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Security.Cryptography;

namespace SessionManagement
{
    public static class HashBuilder
    {
        public static string CreateHash(string plainTxt)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(plainTxt));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                Random random = new Random();

                //Add a dash of salt at the end
                return builder.ToString() + random.Next(10);
            }
        }
    }
}