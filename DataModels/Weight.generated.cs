//-----------------------------------------------------------------------
// <copyright file="Weight.cs" company="PIONIRA NV">
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
    [XmlRootAttribute("Weight", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class Weight
    {
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        /// <value>
        /// The Value.
        /// </value>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public decimal? Value { get; set; }

        /// <summary>
        /// Gets or sets the Unit.
        /// </summary>
        /// <value>
        /// The Unit.
        /// </value>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string Unit { get; set; }

    }
}
