using Encryptors.Encryptions;
using Encryptors.Interfaces;
using System;
using System.Collections.Generic;

namespace Encryptors.Managers
{
    public class EncryptionManager
    {
        private Dictionary<EncryptingMethods, IEncrypt> _possibleEncryptions;
        private Dictionary<EncryptingMethods, IDecrypt> _possibleDecryptions;

        public EncryptionManager()
        {
            _possibleEncryptions = new Dictionary<EncryptingMethods, IEncrypt>();
            _possibleDecryptions = new Dictionary<EncryptingMethods, IDecrypt>();

            FillPossibleEncryptors();
            FillPossibleDecryptors();
        }

        /// <summary>
        /// Fill the list of all possible encryptors.
        /// </summary>
        private void FillPossibleEncryptors()
        {
            _possibleEncryptions.Add(EncryptingMethods.SHA1, new SHA1Encryptor());
            _possibleEncryptions.Add(EncryptingMethods.MD5, new MD5Encryptor());
            //_possibleEncryptions.Add(EncryptingMethods.Rijndael, new RijndaelEncryptor());
            _possibleEncryptions.Add(EncryptingMethods.AES, new AESEncryptor());
        }

        /// <summary>
        /// Fill the list of all possible decryptors.
        /// </summary>
        private void FillPossibleDecryptors()
        {
            //_possibleDecryptions.Add(EncryptingMethods.Rijndael, new RijndaelEncryptor());
            _possibleDecryptions.Add(EncryptingMethods.AES, new AESEncryptor());
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

            if (encryptor == null) return "[No encryptor found]";

            string encryptedText = String.Empty;

            try
            {
                encryptedText = encryptor.Encrypt(text);
            }
            catch (Exception ex)
            {
                encryptedText = ex.Message;
            }

            return encryptedText;
        }

        /// <summary>
        /// Decrypt a specific text using a specific encryption.
        /// </summary>
        /// <param name="text">Encrypted text to decrypt.</param>
        /// <param name="encryption">The encryption that needs to be used.</param>
        /// <returns>A decrypted text.</returns>
        public string DecryptText(string text, EncryptingMethods encryption)
        {
            IDecrypt decryptor = GetDecryptorByMethod(encryption);

            if (decryptor == null) return "[No decryptor found]";

            string decryptedText = String.Empty;

            try
            {
                decryptedText = decryptor.Decrypt(text);
            }
            catch (Exception ex)
            {
                decryptedText = ex.Message;
            }

            return decryptedText;
        }

        /// <summary>
        /// Search for the encryptor by the chosen encrypting method.
        /// </summary>
        /// <param name="encryption">The method of encryption.</param>
        /// <returns>The found encryptor.</returns>
        private IEncrypt GetEncryptorByMethod(EncryptingMethods encryption)
        {
            IEncrypt encryptor;
            _possibleEncryptions.TryGetValue(encryption, out encryptor);
            return encryptor;
        }

        /// <summary>
        /// Search for the decryptor by the chosen encrypting method.
        /// </summary>
        /// <param name="encryption">The method of encryption.</param>
        /// <returns>The found decryptor.</returns>
        private IDecrypt GetDecryptorByMethod(EncryptingMethods encryption)
        {
            IDecrypt decryptor;
            _possibleDecryptions.TryGetValue(encryption, out decryptor);
            return decryptor;
        }
    }
}
