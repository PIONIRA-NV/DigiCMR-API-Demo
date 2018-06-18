//-----------------------------------------------------------------------
// <copyright file="EmptiesItem.cs" company="PIONIRA NV">
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
    [XmlRootAttribute("EmptiesItem", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class EmptiesItem
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
        /// Gets or sets the Location.
        /// </summary>
        /// <value>
        /// The location.
        /// </value>
        [JsonProperty("location")]
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public CreationState Location { get; set; }

        /// <summary>
        /// Gets or sets the QuantityDelivered.
        /// </summary>
        /// <value>
        /// The QuantityDelivered.
        /// </value>
        [Required]
        [JsonProperty("quantityDelivered")]
        [DataMember]
        public int QuantityDelivered { get; set; }

        /// <summary>
        /// Gets or sets the QuantityReturned.
        /// </summary>
        /// <value>
        /// The QuantityReturned.
        /// </value>
        [Required]
        [JsonProperty("quantityReturned")]
        [DataMember]
        public int QuantityReturned { get; set; }

    }
}
