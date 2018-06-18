//-----------------------------------------------------------------------
// <copyright file="TransportDocumentAnnotations.cs" company="PIONIRA NV">
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
    [XmlRootAttribute("TransportDocumentAnnotations", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class TransportDocumentAnnotations
    {
        /// <summary>
        /// Gets or sets the Id.
        /// The identifier used by Xynaps to identify this document. This data is only available if the document already exists in the Xynaps environment.
        /// </summary>
        /// <value>
        /// The Id.
        /// </value>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or sets the ExternalId.
        /// A unique identifier used by the subsystem that created the message.
        /// </summary>
        /// <value>
        /// The ExternalId.
        /// </value>
        [JsonProperty("externalId", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or sets the TransportDocumentAttachments.
        /// </summary>
        /// <value>
        /// The TransportDocumentAttachments.
        /// </value>
        [JsonProperty("attachments", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public TransportDocumentAttachmentUpdate[] TransportDocumentAttachments { get; set; }

        /// <summary>
        /// Gets or sets the Empties.
        /// </summary>
        /// <value>
        /// The Empties.
        /// </value>
        [JsonProperty("empties", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public EmptiesItemUpdate[] Empties { get; set; }

        /// <summary>
        /// Gets or sets the ContactId.
        /// </summary>
        /// <value>
        /// The ContactId.
        /// </value>
        [JsonProperty("contactId", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public ContactReference ContactId { get; set; }

        /// <summary>
        /// Gets or sets the Goods.
        /// </summary>
        /// <value>
        /// The Goods.
        /// </value>
        [JsonProperty("goods", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public ProductUpdate[] Goods { get; set; }

        /// <summary>
        /// Gets or sets the Goods.
        /// </summary>
        /// <value>
        /// The Goods.
        /// </value>
        [JsonProperty("goodsText", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string GoodsText { get; set; }

        /// <summary>
        /// Gets or sets the Pickup.
        /// </summary>
        /// <value>
        /// The Pickup.
        /// </value>
        [JsonProperty("pickup", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public Destination Pickup { get; set; }

        /// <summary>
        /// Gets or sets the Delivery.
        /// </summary>
        /// <value>
        /// The Delivery.
        /// </value>
        [JsonProperty("delivery", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public Destination Delivery { get; set; }

        /// <summary>
        /// Gets or sets the Reservation.
        /// </summary>
        /// <value>
        /// The Reservation.
        /// </value>
        [JsonProperty("reservation", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public TransportDocumentComment Reservation { get; set; }

        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        /// <value>
        /// The State.
        /// </value>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        [JsonConverter(typeof(StringEnumConverter))]
        public State State { get; set; }

        /// <summary>
        /// Gets or sets the CreationState.
        /// </summary>
        /// <value>
        /// The CreationState.
        /// </value>
        [JsonProperty("creationState", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        [JsonConverter(typeof(StringEnumConverter))]
        public CreationState CreationState { get; set; }

        /// <summary>
        /// Gets or sets the TransportExecutions.
        /// </summary>
        /// <value>
        /// The TransportExecutions.
        /// </value>
        [JsonProperty("transportExecutions", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public TransportExecution[] TransportExecutions { get; set; }

    }
}
