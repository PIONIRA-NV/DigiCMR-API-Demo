//-----------------------------------------------------------------------
// <copyright file="Address.cs" company="PIONIRA NV">
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
    /// The address information about a party, contact, carrier, destination.
    /// </summary>
    [DataContract(Namespace = "https://www.pionira.be/api/v2")]
    [XmlRootAttribute("Address", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class Address
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
        /// Gets or sets the AdditionalLine.
        /// </summary>
        /// <value>
        /// The AdditionalLine.
        /// </value>
        [JsonProperty("additionalLine", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string AdditionalLine { get; set; }

        /// <summary>
        /// Gets or sets the StreetAddress.
        /// </summary>
        /// <value>
        /// The StreetAddress.
        /// </value>
        [Required]
        [JsonProperty("streetAddress")]
        [DataMember]
        public string StreetAddress { get; set; }

        /// <summary>
        /// Gets or sets the Postalcode.
        /// </summary>
        /// <value>
        /// The Postalcode.
        /// </value>
        [JsonProperty("postalcode", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string Postalcode { get; set; }

        /// <summary>
        /// Gets or sets the City.
        /// </summary>
        /// <value>
        /// The City.
        /// </value>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the CountryCode.
        /// </summary>
        /// <value>
        /// The CountryCode.
        /// </value>
        [JsonProperty("countryCode", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the Longitude.
        /// Longitude in decimal degrees
        /// </summary>
        /// <value>
        /// The Longitude.
        /// </value>
        [JsonProperty("longitude", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public decimal? Longitude { get; set; }

        /// <summary>
        /// Gets or sets the Latitude.
        /// latitude in decimal degrees
        /// </summary>
        /// <value>
        /// The Latitude.
        /// </value>
        [JsonProperty("latitude", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public decimal? Latitude { get; set; }

        /// <summary>
        /// Gets or sets the Text.
        /// The Address as formatted text
        /// </summary>
        /// <value>
        /// The Text.
        /// </value>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string Text { get; set; }

    }
}
