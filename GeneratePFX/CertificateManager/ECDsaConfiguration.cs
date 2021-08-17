using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace GeneratePFX.CertificateManager
{
    public class ECDsaConfiguration
    {
        /// <summary>
        /// EC 256, 384
        /// </summary>
        public int KeySize { get; set; } = 256;

        public HashAlgorithmName HashAlgorithmName { get; set; } = HashAlgorithmName.SHA256;

    }
}
