using Encryptors.Encryptions;
using Encryptors.Interfaces;
using System;
using System.Collections.Generic;

namespace Encryptors.Managers
{
    public class EncryptionManager
    {
        private Dictionary<EncryptingMethods, IEncrypt> _possibleEncryptions;

        public EncryptionManager()
        {
            _possibleEncryptions = new Dictionary<EncryptingMethods, IEncrypt>();

            FillPossibleEncryptors();
        }

        /// <summary>
        /// Fill the list of all possible encryptors.
        /// </summary>
        private void FillPossibleEncryptors()
        {
            _possibleEncryptions.Add(EncryptingMethods.SHA1, new SHA1Encryptor());
            _possibleEncryptions.Add(EncryptingMethods.MD5, new MD5Encryptor());
        }

        /// <summary>
        /// Encrypt a specific text using a specific encryption.
        /// </summary>
        /// <param name="text">Text to encrypt.</param>
        /// <param name="encryption">The encryption that needs to be used.</param>
        /// <returns>An encrypted text.</returns>
        public string EncryptText(string text, EncryptingMethods encryption)
        {
            IEncrypt encryptor = GetEncryptorByMethod(encryption);

            if (encryptor == null) return String.Empty;

            return encryptor.Encrypt(text);
        }

        /// <summary>
        /// Search for the encryptor by the chosen encryting method.
        /// </summary>
        /// <param name="encryption">The method of encryption.</param>
        /// <returns>The found encryptor.</returns>
        private IEncrypt GetEncryptorByMethod(EncryptingMethods encryption)
        {
            IEncrypt encryptor;
            _possibleEncryptions.TryGetValue(encryption, out encryptor);
            return encryptor;
        }
    }
}
