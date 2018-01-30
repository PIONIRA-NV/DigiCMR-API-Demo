//-----------------------------------------------------------------------
// <copyright file="CollaborationSettings.cs" company="PIONIRA NV">
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
    [XmlRootAttribute("CollaborationSettings", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class CollaborationSettings
    {
        /// <summary>
        /// Gets or sets the Collaborate.
        /// Indicate if you want to setup or teardown collaborative sharing with this party. If true, the collaborative connection will be set up by sending an e-mail to the e-mail address supplied by the emailAddress property in this object.
        /// </summary>
        /// <value>
        /// The Collaborate.
        /// </value>
        [Required]
        [JsonProperty("collaborate")]
        [DataMember]
        public bool Collaborate { get; set; }

        /// <summary>
        /// Gets or sets the EmailAddress.
        /// </summary>
        /// <value>
        /// The EmailAddress.
        /// </value>
        [Required]
        [JsonProperty("emailAddress")]
        [DataMember]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the CollaborationScope.
        /// </summary>
        /// <value>
        /// The CollaborationScope.
        /// </value>
        [Required]
        [JsonProperty("collaborationScope")]
        [DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public CollaborationScope CollaborationScope { get; set; }

    }
}
