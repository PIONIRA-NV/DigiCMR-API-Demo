//-----------------------------------------------------------------------
// <copyright file="Driver.cs" company="PIONIRA NV">
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
    [XmlRootAttribute("Driver", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class Driver: ContactReference
    {
        /// <summary>
        /// Gets or sets the Carrier.
        /// </summary>
        /// <value>
        /// The Carrier.
        /// </value>
        [Required]
        [JsonProperty("carrier")]
        [DataMember]
        public ContactReference Carrier { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        /// <value>
        /// The Name.
        /// </value>
        [Required]
        [JsonProperty("name")]
        [DataMember]
        public string Name { get; set; }

    }
}
