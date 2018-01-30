//-----------------------------------------------------------------------
// <copyright file="TransportDocumentAttachment.cs" company="PIONIRA NV">
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
    [XmlRootAttribute("TransportDocumentAttachment", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class TransportDocumentAttachment
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
        [Required]
        [JsonProperty("externalId")]
        [DataMember]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or sets the DateCreated.
        /// </summary>
        /// <value>
        /// The DateCreated.
        /// </value>
        [JsonProperty("dateCreated", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        /// <value>
        /// The DisplayName.
        /// </value>
        [Required]
        [JsonProperty("displayName")]
        [DataMember]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the Type.
        /// </summary>
        /// <value>
        /// The Type.
        /// </value>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the MimeType.
        /// </summary>
        /// <value>
        /// The MimeType.
        /// </value>
        [JsonProperty("mimeType", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string MimeType { get; set; }

        /// <summary>
        /// Gets or sets the Remarks.
        /// </summary>
        /// <value>
        /// The Remarks.
        /// </value>
        [JsonProperty("remarks", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string Remarks { get; set; }

        /// <summary>
        /// Gets or sets the Content.
        /// The content of the attachement as a base64 encoded string
        /// </summary>
        /// <value>
        /// The Content.
        /// </value>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the Uri.
        /// The location of the attachment
        /// </summary>
        /// <value>
        /// The Uri.
        /// </value>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string Uri { get; set; }

    }
}
