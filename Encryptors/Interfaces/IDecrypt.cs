using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptors.Interfaces
{
    public interface IDecrypt
    {
        /// <summary>
        /// Decrypt a certain text.
        /// </summary>
        /// <param name="text">The text to decrypt.</param>
        /// <returns>The decrypted text.</returns>
        string Decrypt(string text);
    }
}
