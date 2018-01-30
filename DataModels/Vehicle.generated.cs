//-----------------------------------------------------------------------
// <copyright file="Vehicle.cs" company="PIONIRA NV">
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
    [XmlRootAttribute("Vehicle", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class Vehicle
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
        /// A unique identifier used by the subsystem to identify this resource. Use this identifier in each subsequent message sent to the Xynaps service.
        /// </summary>
        /// <value>
        /// The ExternalId.
        /// </value>
        [Required]
        [JsonProperty("externalId")]
        [DataMember]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        /// <value>
        /// The Name.
        /// </value>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the LicensePlate.
        /// </summary>
        /// <value>
        /// The LicensePlate.
        /// </value>
        [Required]
        [JsonProperty("licensePlate")]
        [DataMember]
        public string LicensePlate { get; set; }

        /// <summary>
        /// Gets or sets the TruckloadCapacity.
        /// </summary>
        /// <value>
        /// The TruckloadCapacity.
        /// </value>
        [JsonProperty("truckloadCapacity", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public Weight TruckloadCapacity { get; set; }

        /// <summary>
        /// Gets or sets the TruckloadVolume.
        /// </summary>
        /// <value>
        /// The TruckloadVolume.
        /// </value>
        [JsonProperty("truckloadVolume", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public Volume TruckloadVolume { get; set; }

    }
}
