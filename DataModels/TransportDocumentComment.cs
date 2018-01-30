  
//-----------------------------------------------------------------------
// <copyright file="TransportDocumentComment.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace  Xynaps.Api.Models
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// 
    /// </summary>
    public partial class TransportDocumentComment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportDocumentComment"/> class.
        /// </summary>
        public TransportDocumentComment()
        {
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is carrier.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is carrier; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("fromCarrier", NullValueHandling = NullValueHandling.Ignore)]
        public bool FromCarrier { get; set; }
    }
}
