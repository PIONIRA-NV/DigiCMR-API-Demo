//-----------------------------------------------------------------------
// <copyright file="Destination.cs" company="PIONIRA NV">
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
    [XmlRootAttribute("Destination", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class Destination: Contact
    {
        /// <summary>
        /// Gets or sets the Datetime.
        /// Planned arrival time at the destination. Time must include the timezone designator (TZD)
        /// </summary>
        /// <value>
        /// The Datetime.
        /// </value>
        [JsonProperty("datetime", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public DateTime? Datetime { get; set; }

        /// <summary>
        /// Gets or sets the Arrival.
        /// Actual registered arrival time at the destination in UTC.
        /// </summary>
        /// <value>
        /// The Arrival.
        /// </value>
        [JsonProperty("arrival", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public DateTime? Arrival { get; set; }

        /// <summary>
        /// Gets or sets the Departure.
        /// Actual registered departure time from the destination in UTC.
        /// </summary>
        /// <value>
        /// The Departure.
        /// </value>
        [JsonProperty("departure", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public DateTime? Departure { get; set; }

        /// <summary>
        /// Gets or sets the Reference.
        /// </summary>
        /// <value>
        /// The Reference.
        /// </value>
        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or sets the Remarks.
        /// </summary>
        /// <value>
        /// The Remarks.
        /// </value>
        [JsonProperty("remarks", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string Remarks { get; set; }

    }
}
