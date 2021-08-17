using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratePFX
{
    public static class CertificateManagerExtensions
    {
        public static IServiceCollection AddCertificateManager(this IServiceCollection services)
        {
            // internal
            services.AddTransient<CertificateUtility>();

            // public
            services.AddTransient<ImportExportCertificate>();
            services.AddTransient<CreateCertificates>();
            services.AddTransient<CreateCertificatesClientServerAuth>();
            services.AddTransient<CreateCertificatesRsa>();

            return services;
        }
    }
}
