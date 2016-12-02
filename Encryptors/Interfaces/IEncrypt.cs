namespace Encryptors.Interfaces
{
    public interface IEncrypt
    {
        /// <summary>
        /// Encrypt a text.
        /// </summary>
        /// <param name="text">The text to encrypt.</param>
        /// <returns>The encrypted text.</returns>
        string Encrypt(string text);
    }
}
