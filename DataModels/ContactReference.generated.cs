//-----------------------------------------------------------------------
// <copyright file="ContactReference.cs" company="PIONIRA NV">
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
    [XmlRootAttribute("ContactReference", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class ContactReference
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
        [JsonProperty("externalId", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string ExternalId { get; set; }

    }
}
