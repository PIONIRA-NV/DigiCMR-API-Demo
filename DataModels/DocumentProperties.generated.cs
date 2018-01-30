//-----------------------------------------------------------------------
// <copyright file="DocumentProperties.cs" company="PIONIRA NV">
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
    /// This type describes specifics about the creation or representation of the document when generating a pdf, or printing the consignment note.
    /// </summary>
    [DataContract(Namespace = "https://www.pionira.be/api/v2")]
    [XmlRootAttribute("DocumentProperties", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class DocumentProperties
    {
        /// <summary>
        /// Gets or sets the CountryLayout.
        /// Specifies the specific layout to use when a pdf needs to be generated or document needs to be printed.
        /// This is the 2 character ISO standards country code. For the international layout specify the code "ZZ"
        /// </summary>
        /// <value>
        /// The CountryLayout.
        /// </value>
        [JsonProperty("countryLayout", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string CountryLayout { get; set; }

        /// <summary>
        /// Gets or sets the Pages.
        /// The number of numbered CMR pages in the document
        /// </summary>
        /// <value>
        /// The Pages.
        /// </value>
        [JsonProperty("pages", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public int? Pages { get; set; }

        /// <summary>
        /// Gets or sets the Printer.
        /// The printer name where to send the document for printing. Only if a Xynaps printing service is installed on-premise.
        /// </summary>
        /// <value>
        /// The Printer.
        /// </value>
        [JsonProperty("printer", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string Printer { get; set; }

    }
}
