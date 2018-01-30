//-----------------------------------------------------------------------
// <copyright file="Package.cs" company="PIONIRA NV">
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
    [XmlRootAttribute("Package", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class Package
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
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Code.
        /// </summary>
        /// <value>
        /// The Code.
        /// </value>
        [Required]
        [JsonProperty("code")]
        [DataMember]
        public string Code { get; set; }

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
        /// Gets or sets the Description.
        /// </summary>
        /// <value>
        /// The Description.
        /// </value>
        [Required]
        [JsonProperty("description")]
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Quantity.
        /// </summary>
        /// <value>
        /// The Quantity.
        /// </value>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public int? Quantity { get; set; }

    }
}
