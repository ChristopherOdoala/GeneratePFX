using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratePFX.CertificateManager
{
    public class BasicConstraints
    {
        public bool CertificateAuthority { get; set; }

        public bool HasPathLengthConstraint { get; set; }

        public int PathLengthConstraint { get; set; }

        public bool Critical { get; set; }
    }
}
