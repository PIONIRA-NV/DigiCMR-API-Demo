//-----------------------------------------------------------------------
// <copyright file="TransportDocumentComment.cs" company="PIONIRA NV">
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
    /// Reservations, comments or observations entered by the carrier or one of the other parties at signoff.
    /// </summary>
    [DataContract(Namespace = "https://www.pionira.be/api/v2")]
    [XmlRootAttribute("TransportDocumentComment", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class TransportDocumentComment
    {
        /// <summary>
        /// Gets or sets the Id.
        /// A unique identifier used to identify this resource in the Xynaps platform.
        /// </summary>
        /// <value>
        /// The Id.
        /// </value>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or sets the ExternalId.
        /// A unique identifier used by the subsystem to identify this resource.
        /// </summary>
        /// <value>
        /// The ExternalId.
        /// </value>
        [JsonProperty("externalId", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or sets the Text.
        /// </summary>
        /// <value>
        /// The Text.
        /// </value>
        [Required]
        [JsonProperty("text")]
        [DataMember]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the CreationState.
        /// </summary>
        /// <value>
        /// The CreationState.
        /// </value>
        [Required]
        [JsonProperty("creationState")]
        [DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public CreationState CreationState { get; set; }

        /// <summary>
        /// Gets or sets the ContactId.
        /// </summary>
        /// <value>
        /// The ContactId.
        /// </value>
        [Required]
        [JsonProperty("contactId")]
        [DataMember]
        public ContactReference ContactId { get; set; }

        /// <summary>
        /// Gets or sets the Role.
        /// A descriptive indication of the role of the author, e.g. 'CARRIER', 'CONSIGNOR', 'CONSIGNEE', ...
        /// </summary>
        /// <value>
        /// The Role.
        /// </value>
        [Required]
        [JsonProperty("role")]
        [DataMember]
        public string Role { get; set; }

    }
}
