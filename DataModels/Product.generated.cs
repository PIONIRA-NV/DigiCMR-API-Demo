//-----------------------------------------------------------------------
// <copyright file="Product.cs" company="PIONIRA NV">
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
    [XmlRootAttribute("Product", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class Product
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
        /// Gets or sets the Sku.
        /// Stock keeping unit
        /// </summary>
        /// <value>
        /// The Sku.
        /// </value>
        [JsonProperty("sku", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string Sku { get; set; }

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
        /// Gets or sets the LotNumber.
        /// </summary>
        /// <value>
        /// The LotNumber.
        /// </value>
        [JsonProperty("lotNumber", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string LotNumber { get; set; }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        /// <value>
        /// The Description.
        /// </value>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string Description { get; set; }

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
        /// Gets or sets the Quantity.
        /// </summary>
        /// <value>
        /// The Quantity.
        /// </value>
        [Required]
        [JsonProperty("quantity")]
        [DataMember]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the UnitPrice.
        /// </summary>
        /// <value>
        /// The UnitPrice.
        /// </value>
        [JsonProperty("unitPrice", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public int? UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets the Volume.
        /// </summary>
        /// <value>
        /// The Volume.
        /// </value>
        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public decimal? Volume { get; set; }

        /// <summary>
        /// Gets or sets the VolumeUnit.
        /// </summary>
        /// <value>
        /// The VolumeUnit.
        /// </value>
        [JsonProperty("volumeUnit", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string VolumeUnit { get; set; }

        /// <summary>
        /// Gets or sets the GrossWeight.
        /// Gross Weight. The total weight, including contents, packaging, etc.
        /// </summary>
        /// <value>
        /// The GrossWeight.
        /// </value>
        [JsonProperty("grossWeight", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public decimal? GrossWeight { get; set; }

        /// <summary>
        /// Gets or sets the GrossWeightUnit.
        /// </summary>
        /// <value>
        /// The GrossWeightUnit.
        /// </value>
        [JsonProperty("grossWeightUnit", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string GrossWeightUnit { get; set; }

        /// <summary>
        /// Gets or sets the NetWeight.
        /// Net Weight. The total weight of the raw product.
        /// </summary>
        /// <value>
        /// The NetWeight.
        /// </value>
        [JsonProperty("netWeight", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public decimal? NetWeight { get; set; }

        /// <summary>
        /// Gets or sets the NetWeightUnit.
        /// </summary>
        /// <value>
        /// The NetWeightUnit.
        /// </value>
        [JsonProperty("netWeightUnit", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string NetWeightUnit { get; set; }

        /// <summary>
        /// Gets or sets the PackagingDetails.
        /// </summary>
        /// <value>
        /// The PackagingDetails.
        /// </value>
        [JsonProperty("packagingDetails", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public IList<Package> PackagingDetails { get; set; }

        /// <summary>
        /// Gets or sets the IsReturnable.
        /// Logical true if the product is a returnable good.
        /// </summary>
        /// <value>
        /// The IsReturnable.
        /// </value>
        [JsonProperty("isReturnable", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public bool? IsReturnable { get; set; }

    }
}
