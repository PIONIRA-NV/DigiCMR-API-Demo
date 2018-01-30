//-----------------------------------------------------------------------
// <copyright file="Organisation.cs" company="PIONIRA NV">
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
    [XmlRootAttribute("Organisation", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class Organisation
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
        [Required]
        [JsonProperty("name")]
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Address.
        /// </summary>
        /// <value>
        /// The Address.
        /// </value>
        [Required]
        [JsonProperty("address")]
        [DataMember]
        public Address Address { get; set; }

        /// <summary>
        /// Gets or sets the EmailAddress.
        /// </summary>
        /// <value>
        /// The EmailAddress.
        /// </value>
        [JsonProperty("emailAddress", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the MobileNumber.
        /// </summary>
        /// <value>
        /// The MobileNumber.
        /// </value>
        [JsonProperty("mobileNumber", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string MobileNumber { get; set; }

        /// <summary>
        /// Gets or sets the TelephoneNumber.
        /// </summary>
        /// <value>
        /// The TelephoneNumber.
        /// </value>
        [JsonProperty("telephoneNumber", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the OrganizationNumber.
        /// The organization's VAT identification number
        /// </summary>
        /// <value>
        /// The OrganizationNumber.
        /// </value>
        [JsonProperty("organizationNumber", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string OrganizationNumber { get; set; }

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

        /// <summary>
        /// Gets or sets the CollaborationSettings.
        /// Settings to setup or describe how you want to collaborate with this Contact (Party) on documents
        /// </summary>
        /// <value>
        /// The CollaborationSettings.
        /// </value>
        [JsonProperty("collaborationSettings", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public CollaborationSettings CollaborationSettings { get; set; }

    }
}
