//-----------------------------------------------------------------------
// <copyright file="Contact.cs" company="PIONIRA NV">
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
    [XmlRootAttribute("Contact", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class Contact
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
        [XmlElement]
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
        [XmlElement]
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
        [XmlElement]
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
        [XmlElement]
        public Address Address { get; set; }

        /// <summary>
        /// Gets or sets the EmailAddress.
        /// </summary>
        /// <value>
        /// The EmailAddress.
        /// </value>
        [JsonProperty("emailAddress", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        [XmlElement]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the MobileNumber.
        /// </summary>
        /// <value>
        /// The MobileNumber.
        /// </value>
        [JsonProperty("mobileNumber", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        [XmlElement]
        public string MobileNumber { get; set; }

        /// <summary>
        /// Gets or sets the TelephoneNumber.
        /// </summary>
        /// <value>
        /// The TelephoneNumber.
        /// </value>
        [JsonProperty("telephoneNumber", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        [XmlElement]
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
        [XmlElement]
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
        [XmlElement]
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
        [XmlElement]
        public CollaborationSettings CollaborationSettings { get; set; }

        /// <summary>
        /// Gets or sets the SignatureText.
        /// The stamp or information to be displayed in the signature field when the contact signs the document.
        /// </summary>
        /// <value>
        /// The SignatureText.
        /// </value>
        [JsonProperty("signatureText", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        [XmlElement]
        public string SignatureText { get; set; }

        /// <summary>
        /// Gets or sets the SignatureImage.
        /// The image of a signature captured from a sign on glass solution. This needs to be the base64 encoded string of the image. The use of the https://www.ietf.org/rfc/rfc2397.txt data uri scheme is also supported.
        /// </summary>
        /// <value>
        /// The SignatureImage.
        /// </value>
        [JsonProperty("signatureImage", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        [XmlElement]
        public string SignatureImage { get; set; }

        /// <summary>
        /// Gets or sets the SignatureName.
        /// The name of the signer to be displayed in the signature field when the contact signs the document.
        /// </summary>
        /// <value>
        /// The SignatureName.
        /// </value>
        [JsonProperty("signatureName", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        [XmlElement]
        public string SignatureName { get; set; }

        /// <summary>
        /// Gets or sets the signature date.
        /// </summary>
        /// <value>The signature date.</value>
        [JsonProperty("SignatureDate", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        [XmlElement]
        public DateTime? SignatureDate { get; set; }
    }
}
