//-----------------------------------------------------------------------
// <copyright file="CurrencyAmount.cs" company="PIONIRA NV">
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
    [XmlRootAttribute("CurrencyAmount", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class CurrencyAmount
    {
        /// <summary>
        /// Gets or sets the Amount.
        /// </summary>
        /// <value>
        /// The Amount.
        /// </value>
        [Required]
        [JsonProperty("amount")]
        [DataMember]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the Currency.
        /// The 3 letter ISO 4217 currency code. (http://www.iso.org/iso/home/standards/currency_codes.htm)
        /// </summary>
        /// <value>
        /// The Currency.
        /// </value>
        [Required]
        [JsonProperty("currency")]
        [DataMember]
        public string Currency { get; set; }

    }
}
