//-----------------------------------------------------------------------
// <copyright file="VerifiedGrossMass.cs" company="PIONIRA NV">
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
    [XmlRootAttribute("VerifiedGrossMass", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class VerifiedGrossMass
    {
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        /// <value>
        /// The Value.
        /// </value>
        [Required]
        [JsonProperty("value")]
        [DataMember]
        public decimal Value { get; set; }

        /// <summary>
        /// Gets or sets the Uom.
        /// </summary>
        /// <value>
        /// The Uom.
        /// </value>
        [Required]
        [JsonProperty("uom")]
        [DataMember]
        public string Uom { get; set; }

        /// <summary>
        /// Gets or sets the WeighingDate.
        /// </summary>
        /// <value>
        /// The WeighingDate.
        /// </value>
        [Required]
        [JsonProperty("weighingDate")]
        [DataMember]
        public DateTime WeighingDate { get; set; }

        /// <summary>
        /// Gets or sets the VerificationMethod.
        /// </summary>
        /// <value>
        /// The VerificationMethod.
        /// </value>
        [Required]
        [JsonProperty("verificationMethod")]
        [DataMember]
        public string VerificationMethod { get; set; }

    }
}
