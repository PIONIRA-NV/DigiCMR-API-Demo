//-----------------------------------------------------------------------
// <copyright file="TransportDocumentReturnState.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Xynaps.Api.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    /// <summary>
    /// 
    /// </summary>
    [DataContract(Namespace = "https://www.pionira.be/api/v2")]
    [XmlRootAttribute("TransportDocumentReturnState", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class TransportDocumentReturnState
    {
        /// <summary>
        /// Gets or sets the Id.
        /// "Internal Xynaps identifier of the created document."
        /// </summary>
        /// <value>
        /// The Id.
        /// </value>
        [Required]
        [JsonProperty("id")]
        [DataMember]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the ExternalId.
        /// "A unique identifier used by the subsystem that created the message."
        /// </summary>
        /// <value>
        /// The ExternalId.
        /// </value>
        [Required]
        [JsonProperty("externalId")]
        [DataMember]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        /// <value>
        /// The State.
        /// </value>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        [JsonConverter(typeof(StringEnumConverter))]
        public State State { get; set; }

        /// <summary>
        /// Gets or sets the CmrNumber.
        /// Only available if the document is in the issued or signed states. This is the official number of the document.
        /// </summary>
        /// <value>
        /// The CmrNumber.
        /// </value>
        [JsonProperty("cmrNumber", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string CmrNumber { get; set; }

        /// <summary>
        /// Gets or sets the Timestamp.
        /// The date and time the status of the document was changed. This time is in UTC.
        /// </summary>
        /// <value>
        /// The Timestamp.
        /// </value>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the Error.
        /// </summary>
        /// <value>
        /// The Error.
        /// </value>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public ErrorMessage Error { get; set; }

    }
}
