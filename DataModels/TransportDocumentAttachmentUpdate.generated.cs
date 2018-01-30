//-----------------------------------------------------------------------
// <copyright file="TransportDocumentAttachmentUpdate.cs" company="PIONIRA NV">
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
    [XmlRootAttribute("TransportDocumentAttachmentUpdate", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class TransportDocumentAttachmentUpdate: TransportDocumentAttachment
    {
        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        /// <value>
        /// The State.
        /// </value>
        [JsonProperty("State", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        [JsonConverter(typeof(StringEnumConverter))]
        public EntityState State { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        /// <value>
        /// The Name.
        /// </value>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string Name { get; set; }

    }
}
