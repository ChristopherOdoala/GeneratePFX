using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratePFX.CertificateManager
{
    public class ValidityPeriod
    {
        public DateTimeOffset ValidFrom { get; set; }
        public DateTimeOffset ValidTo { get; set; }
    }
}
