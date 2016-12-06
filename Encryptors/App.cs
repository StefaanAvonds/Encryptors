using Encryptors.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptors
{
    public static class App
    {
        private static EncryptionManager _encryptionManager;

        /// <summary>
        /// Manages all encryptions.
        /// </summary>
        public static EncryptionManager EncryptionManager
        {
            get
            {
                if (_encryptionManager == null) _encryptionManager = new EncryptionManager();
                return _encryptionManager;
            }
        }
    }
}
