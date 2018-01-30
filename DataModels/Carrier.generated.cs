//-----------------------------------------------------------------------
// <copyright file="Carrier.cs" company="PIONIRA NV">
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
    [XmlRootAttribute("Carrier", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class Carrier: Contact
    {
        /// <summary>
        /// Gets or sets the LicensePlate.
        /// </summary>
        /// <value>
        /// The LicensePlate.
        /// </value>
        [JsonProperty("licensePlate", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string LicensePlate { get; set; }

        /// <summary>
        /// Gets or sets the License.
        /// </summary>
        /// <value>
        /// The License.
        /// </value>
        [JsonProperty("license", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string License { get; set; }

    }
}
