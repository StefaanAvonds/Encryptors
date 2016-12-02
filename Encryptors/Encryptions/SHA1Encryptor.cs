using Encryptors.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace Encryptors.Encryptions
{
    public class SHA1Encryptor : IEncrypt
    {
        /// <summary>
        /// Encrypt a text using SHA1.
        /// </summary>
        /// <param name="text">The text to encrypt.</param>
        /// <returns>The encrypted text.</returns>
        public string Encrypt(string text)
        {
            using (var sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(text));

                StringBuilder builder = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash) builder.Append(b.ToString("X2"));

                return builder.ToString();
            }
        }
    }
}
