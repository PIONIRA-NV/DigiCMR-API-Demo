//-----------------------------------------------------------------------
// <copyright file="ErrorMessage.cs" company="PIONIRA NV">
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
    [XmlRootAttribute("ErrorMessage", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class ErrorMessage
    {
        /// <summary>
        /// Gets or sets the Message.
        /// </summary>
        /// <value>
        /// The Message.
        /// </value>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the Details.
        /// </summary>
        /// <value>
        /// The Details.
        /// </value>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public object Details { get; set; }

    }
}
