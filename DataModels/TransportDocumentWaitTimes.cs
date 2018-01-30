//-----------------------------------------------------------------------
// <copyright file="TransportDocumentWaitTimes.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Xynaps.Api.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class TransportDocumentWaitTimes.
    /// </summary>
    [DataContract(Namespace = "https://www.pionira.be/api/v2")]
    public class TransportDocumentWaitTimes
    {
        /// <summary>
        /// Gets or sets the arrived.
        /// </summary>
        /// <value>The arrived.</value>
        [JsonProperty("arrived", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember]
        public DateTimeOffset? Arrived { get; set; }

        /// <summary>
        /// Gets or sets the departed.
        /// </summary>
        /// <value>The departed.</value>
        [JsonProperty("departed", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember]
        public DateTimeOffset? Departed { get; set; }
    }
}