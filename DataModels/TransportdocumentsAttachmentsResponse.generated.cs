//-----------------------------------------------------------------------
// <copyright file="TransportdocumentsAttachmentsResponse.cs" company="PIONIRA NV">
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
    [XmlRootAttribute("TransportdocumentsAttachmentsResponse", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class TransportdocumentsAttachmentsResponse
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        /// <value>
        /// The Id.
        /// </value>
        [Required]
        [JsonProperty("id")]
        [DataMember]
        public long Id { get; set; }

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
