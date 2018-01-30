//-----------------------------------------------------------------------
// <copyright file="IDigiCMRApiDemo.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DigiCMRApi
{
    using System.Threading.Tasks;

    /// <summary>
    /// Interface IDigiCMRApiDemo
    /// </summary>
    public interface IDigiCMRApiDemo
    {
        /// <summary>
        /// Creates the transport document.
        /// </summary>
        /// <returns>Task.</returns>
        Task CreateTransportDocument();

        /// <summary>
        /// Creates the transport document attachment.
        /// </summary>
        /// <returns>Task.</returns>
        Task CreateTransportDocumentAttachment();

        /// <summary>
        /// Get the first 10 the transport documents.
        /// </summary>
        /// <returns>Task.</returns>
        Task Get10TransportDocuments();

        /// <summary>
        /// Gets the transport document.
        /// </summary>
        /// <returns>Task.</returns>
        Task GetTransportDocument();

        /// <summary>
        /// Gets the transport document as PDF.
        /// </summary>
        /// <returns>Task.</returns>
        Task GetTransportDocumentAsPdf();

        /// <summary>
        /// Gets the transport document attachments.
        /// </summary>
        /// <returns>Task.</returns>
        Task GetTransportDocumentAttachments();

        /// <summary>
        /// Gets the transport document by external identifier.
        /// </summary>
        /// <returns>Task.</returns>
        Task GetTransportDocumentByExternalId();

        /// <summary>
        /// Gets the transport document states.
        /// </summary>
        /// <returns>Task.</returns>
        Task GetTransportDocumentStates();

        /// <summary>
        /// Gets the transport document states since.
        /// </summary>
        /// <returns>Task.</returns>
        Task GetTransportDocumentStatesSince();

        /// <summary>
        /// Issues the transport document.
        /// </summary>
        /// <returns>Task.</returns>
        Task IssueTransportDocument();

        /// <summary>
        /// Prints the transport document.
        /// </summary>
        /// <returns>Task.</returns>
        Task PrintTransportDocument();

        /// <summary>
        /// Updates the transport document.
        /// </summary>
        /// <returns>Task.</returns>
        Task UpdateTransportDocument();
    }
}