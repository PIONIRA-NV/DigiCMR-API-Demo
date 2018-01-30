  
//-----------------------------------------------------------------------
// <copyright file="TransportDocumentAttachment.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace  Xynaps.Api.Models
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// 
    /// </summary>
    public partial class TransportDocumentAttachment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportDocumentAttachment"/> class.
        /// </summary>
        public TransportDocumentAttachment()
        {
        }

        /// <summary>
        /// Gets or sets the filename.
        /// </summary>
        /// <value>
        /// The filename.
        /// </value>
        [DataMember]
        public string Filename { get; set; }
        
        /// <summary>
        /// Gets or sets the external document identifier.
        /// </summary>
        /// <value>The external document identifier.</value>
        [DataMember]
        public string ExternalDocumentId { get; set; }
    }
}
