//-----------------------------------------------------------------------
// <copyright file="TransportExecution.cs" company="PIONIRA NV">
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
    [XmlRootAttribute("TransportExecution", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class TransportExecution
    {
        /// <summary>
        /// Gets or sets the Driver.
        /// </summary>
        /// <value>
        /// The Driver.
        /// </value>
        [JsonProperty("driver", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public Driver Driver { get; set; }

        /// <summary>
        /// Gets or sets the Truck.
        /// </summary>
        /// <value>
        /// The Truck.
        /// </value>
        [JsonProperty("truck", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public Vehicle Truck { get; set; }

        /// <summary>
        /// Gets or sets the Trailer.
        /// </summary>
        /// <value>
        /// The Trailer.
        /// </value>
        [JsonProperty("trailer", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public Vehicle Trailer { get; set; }

    }
}
