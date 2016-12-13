using Encryptors.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encryptors.Encryptions
{
    public class RFC2898Encryptor : IEncrypt, IDecrypt
    {
        private string _encryptionKey;

        public RFC2898Encryptor()
        {
            // Encryption key must be something else and not hard coded!
            _encryptionKey = "encryptionkey";
        }

        public string Encrypt(string text)
        {
            byte[] byteArray = Encoding.Unicode.GetBytes(text);

            using (Aes aes = Aes.Create())
            {
                Rfc2898DeriveBytes crypto = new Rfc2898DeriveBytes(_encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                aes.Key = crypto.GetBytes(32);
                aes.IV = crypto.GetBytes(16);

                using (MemoryStream stream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(stream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(byteArray, 0, byteArray.Length);
                        cryptoStream.Close();
                    }
                    text = Convert.ToBase64String(stream.ToArray());
                }
            }

            return text;
        }

        public string Decrypt(string text)
        {
            text = text.Replace(" ", "+");

            byte[] byteArray = Convert.FromBase64String(text);

            using (Aes aes = Aes.Create())
            {
                Rfc2898DeriveBytes crypto = new Rfc2898DeriveBytes(_encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                aes.Key = crypto.GetBytes(32);
                aes.IV = crypto.GetBytes(16);

                using (MemoryStream stream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(stream, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(byteArray, 0, byteArray.Length);
                        cryptoStream.Close();
                    }
                    text = Encoding.Unicode.GetString(stream.ToArray());
                }
            }

            return text;
        }
    }
}
