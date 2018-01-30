//-----------------------------------------------------------------------
// <copyright file="RelatedContact.cs" company="PIONIRA NV">
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
    [XmlRootAttribute("RelatedContact", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class RelatedContact
    {
        /// <summary>
        /// Gets or sets the Contact.
        /// The contact
        /// </summary>
        /// <value>
        /// The Contact.
        /// </value>
        [JsonProperty("contact", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public Contact Contact { get; set; }

        /// <summary>
        /// Gets or sets the Role.
        /// </summary>
        /// <value>
        /// The Role.
        /// </value>
        [Required]
        [JsonProperty("role")]
        [DataMember]
        public string Role { get; set; }

    }
}
