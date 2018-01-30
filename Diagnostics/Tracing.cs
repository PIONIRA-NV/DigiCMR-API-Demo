//-----------------------------------------------------------------------
// <copyright file="Tracing.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DigiCMR.Framework
{
    using System;
    using System.Diagnostics;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;

    /// <summary>
    /// Provides methods to write diagnostic messages to the DigiCMR.Web <see cref="TraceSource"/>.
    /// </summary>
    public static partial class Tracing
    {
        /// <summary>
        /// Adds the trace listener.
        /// </summary>
        /// <param name="listener">The listener.</param>
        /// <param name="sourceLevels">The source levels.</param>
        public static void AddListener(TraceListener listener, SourceLevels sourceLevels)
        {
            TraceSource.Switch.Level = sourceLevels;
            TraceSource.Listeners.Add(listener);
        }

        /// <summary>
        /// Traces failure to execute an email template to the DigiCMR.Web <see
        /// cref="System.Diagnostics.TraceSource"/> with id 1001.
        /// </summary>
        /// <param name="templateFile">The template file.</param>
        /// <param name="exception">The exception.</param>
        public static void BadMailTemplate(string templateFile, Exception exception)
        {
            TraceError(1001, "Failed executing e-mail template {0}: {1}", templateFile, exception);
        }

        /// <summary>
        /// Traces failure to validate the certificate chain to the DigiCMR.Web <see
        /// cref="System.Diagnostics.TraceSource"/> with id 1002.
        /// </summary>
        /// <param name="certificate">The certificate whose chain trust validation failed.</param>
        /// <param name="chain">The X509Chain instance used to perform the chain trust validation.</param>
        public static void CertificateChainTrustValidationFailed(X509Certificate2 certificate, X509Chain chain)
        {
            var chainStatusInfo = new StringBuilder();
            foreach (var statusInfo in chain.ChainStatus)
            {
                chainStatusInfo.AppendFormat("chain status {0} :  {1}", statusInfo.Status, statusInfo.StatusInformation);
                chainStatusInfo.AppendLine();
            }

            TraceError(
                1002,
                "Failed to validate the certificate chain for the certificate with subjectname {0}. {2}",
                certificate.Subject,
                chainStatusInfo);
        }

        /// <summary>
        /// Certificates the expiry validation failed.
        /// </summary>
        /// <param name="certificate">The certificate.</param>
        /// <exception cref="System.ArgumentNullException">certificate</exception>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "Need X502Certificate2")]
        public static void CertificateExpiryValidationFailed(X509Certificate2 certificate)
        {
            if (certificate == null)
            {
                throw new ArgumentNullException("certificate");
            }

            TraceError(
                1005,
                "Certificate is with subjectname {0} is expired",
                certificate.Subject);
        }

        /// <summary>
        /// Certificates the mapping failed.
        /// </summary>
        /// <param name="certificate">The certificate.</param>
        /// <param name="userName">Name of the user.</param>
        /// <exception cref="System.ArgumentNullException">certificate</exception>
        public static void CertificateMappingFailed(X509Certificate2 certificate, string userName)
        {
            if (certificate == null)
            {
                throw new ArgumentNullException("certificate");
            }

            TraceError(
                1006,
                "Certificate with subjectname {0} could not be mapped to user {1}",
                certificate.Subject,
                userName);
        }

        /// <summary>
        /// Traces failure to validate the certificate, to the DigiCMR.Web <see
        /// cref="System.Diagnostics.TraceSource"/> with id 1003.
        /// </summary>
        /// <param name="certificate">The certificate.</param>
        /// <param name="exception">The exception.</param>
        public static void CertificateValidationFailed(X509Certificate2 certificate, Exception exception)
        {
            TraceError(
                1003,
                "Failed to locate exactly one entry in the Certificates table for the certificate with subjectname {0} : {1}.",
                certificate.Subject,
                exception);
        }

        /// <summary>
        /// Determines if tracing code should be executed, based on the trace event type.
        /// </summary>
        /// <param name="eventType">Type of the event.</param>
        /// <returns>true if tracing code should be executed; otherwise false.</returns>
        public static bool ShouldTrace(TraceEventType eventType)
        {
            return TraceSource.Switch.ShouldTrace(eventType);
        }
    }
}