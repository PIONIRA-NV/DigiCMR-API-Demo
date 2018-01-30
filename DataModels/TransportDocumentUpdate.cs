//-----------------------------------------------------------------------
// <copyright file="TransportDocumentUpdates.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Xynaps.Api.Models
{
    using Newtonsoft.Json;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class TransportDocumentUpdate.
    /// </summary>
    [DataContract(Namespace = "https://www.pionira.be/api/v2")]
    [GeneratedCode("RAML Server Scaffolder", "3.0.0.0")]
    public partial class TransportDocumentUpdate
    {
        /// <summary>
        /// Gets or sets the CmrNumber.
        /// </summary>
        /// <value>
        /// The CmrNumber.
        /// </value>
        [JsonProperty("cmrNumber", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember]
        public string CmrNumber { get; set; }

        /// <summary>
        /// Gets or sets the delivery wait times.
        /// </summary>
        /// <value>The delivery wait times.</value>
        [JsonProperty("deliveryWaitTimes", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember]
        public TransportDocumentWaitTimes DeliveryWaitTimes { get; set; }

        /// <summary>
        /// Gets or sets the Empties.
        /// </summary>
        /// <value>
        /// The Empties.
        /// </value>
        [JsonProperty("empties", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember]
        public IList<EmptiesItem> Empties { get; set; }

        /// <summary>
        /// Gets or sets the ExternalId.
        /// </summary>
        /// <value>The ExternalId.</value>
        [Required]
        [JsonProperty("externalId")]
        [DataMember]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or sets the Goods.
        /// </summary>
        /// <value>
        /// The Goods.
        /// </value>
        [JsonProperty("goods", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember]
        public IList<Product> Goods { get; set; }

        /// <summary>
        /// Gets or sets the GoodsText.
        /// </summary>
        /// <value>
        /// The GoodsText.
        /// </value>
        [JsonProperty("goodsText", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember]
        public string GoodsText { get; set; }

        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        /// <value>The Id.</value>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or sets the OrderNumber.
        /// </summary>
        /// <value>
        /// The OrderNumber.
        /// </value>
        [JsonProperty("orderNumber", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Gets or sets the pickup wait times.
        /// </summary>
        /// <value>The pickup wait times.</value>
        [JsonProperty("pickupWaitTimes", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember]
        public TransportDocumentWaitTimes PickupWaitTimes { get; set; }
    }
}