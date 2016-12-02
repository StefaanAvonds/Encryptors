using Encryptors.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encryptors.Encryptions
{
    public class MD5Encryptor : IEncrypt
    {
        /// <summary>
        /// Encrypt a text using MD5.
        /// </summary>
        /// <param name="text">The text to encrypt.</param>
        /// <returns>The encrypted text.</returns>
        public string Encrypt(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            byte[] result = md5.Hash;

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < result.Length; i++)
            {
                builder.Append(result[i].ToString("x2"));
            }

            return builder.ToString();
        }
    }
}
