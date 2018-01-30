//-----------------------------------------------------------------------
// <copyright file="TransportDocument.cs" company="PIONIRA NV">
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
    /// Represents the transport document, in particular the Consignment Note.
    /// </summary>
    [DataContract(Namespace = "https://www.pionira.be/api/v2")]
    [XmlRootAttribute("TransportDocument", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class TransportDocument
    {
        /// <summary>
        /// Gets or sets the Properties.
        /// </summary>
        /// <value>
        /// The Properties.
        /// </value>
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public DocumentProperties Properties { get; set; }

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
        /// Gets or sets the Company.
        /// Represents the organisation or company who owns this document.
        /// This will be the company that provides the number range for the consignment note number, when the consignment note is issued.
        /// If omitted, the identifier is used of the company of the authenticated account.
        /// </summary>
        /// <value>
        /// The Company.
        /// </value>
        [Required]
        [JsonProperty("company")]
        [DataMember]
        public ContactReference Company { get; set; }

        /// <summary>
        /// Gets or sets the ExternalId.
        /// A unique identifier used by the subsystem that created the message.
        /// </summary>
        /// <value>
        /// The ExternalId.
        /// </value>
        [Required]
        [JsonProperty("externalId")]
        [DataMember]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or sets the CmrNumber.
        /// The number of the issued consignment note.
        /// </summary>
        /// <value>
        /// The CmrNumber.
        /// </value>
        [JsonProperty("cmrNumber", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string CmrNumber { get; set; }

        /// <summary>
        /// Gets or sets the OrderNumber.
        /// </summary>
        /// <value>
        /// The OrderNumber.
        /// </value>
        [JsonProperty("orderNumber", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Gets or sets the DossierNumber.
        /// </summary>
        /// <value>
        /// The DossierNumber.
        /// </value>
        [JsonProperty("dossierNumber", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string DossierNumber { get; set; }

        /// <summary>
        /// Gets or sets the ExternalReferences.
        /// A collection of external references.
        /// </summary>
        /// <value>
        /// The ExternalReferences.
        /// </value>
        [JsonProperty("externalReferences", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public IList<ExternalReference> ExternalReferences { get; set; }

        /// <summary>
        /// Gets or sets the IssuedDate.
        /// The date the document was issued.
        /// </summary>
        /// <value>
        /// The IssuedDate.
        /// </value>
        [JsonProperty("issuedDate", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public DateTime? IssuedDate { get; set; }

        /// <summary>
        /// Gets or sets the IssuedPlace.
        /// The place where the document was issued.
        /// </summary>
        /// <value>
        /// The IssuedPlace.
        /// </value>
        [JsonProperty("issuedPlace", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string IssuedPlace { get; set; }

        /// <summary>
        /// Gets or sets the Consignor.
        /// The consignor
        /// </summary>
        /// <value>
        /// The Consignor.
        /// </value>
        [JsonProperty("consignor", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public Contact Consignor { get; set; }

        /// <summary>
        /// Gets or sets the ConsignorDocuments.
        /// The documents provided by the consignor.
        /// </summary>
        /// <value>
        /// The ConsignorDocuments.
        /// </value>
        [JsonProperty("consignorDocuments", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string ConsignorDocuments { get; set; }

        /// <summary>
        /// Gets or sets the SpecialAgreements.
        /// </summary>
        /// <value>
        /// The SpecialAgreements.
        /// </value>
        [JsonProperty("specialAgreements", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string SpecialAgreements { get; set; }

        /// <summary>
        /// Gets or sets the ConsignorInstructions.
        /// Additional instructions provided by the consignor.
        /// </summary>
        /// <value>
        /// The ConsignorInstructions.
        /// </value>
        [JsonProperty("consignorInstructions", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string ConsignorInstructions { get; set; }

        /// <summary>
        /// Gets or sets the Consignee.
        /// The consignee or adressee.
        /// </summary>
        /// <value>
        /// The Consignee.
        /// </value>
        [JsonProperty("consignee", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public Contact Consignee { get; set; }

        /// <summary>
        /// Gets or sets the Pickup.
        /// The pickup location of the goods.
        /// </summary>
        /// <value>
        /// The Pickup.
        /// </value>
        [JsonProperty("pickup", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public Destination Pickup { get; set; }

        /// <summary>
        /// Gets or sets the Delivery.
        /// The delivery location of the goods.
        /// </summary>
        /// <value>
        /// The Delivery.
        /// </value>
        [JsonProperty("delivery", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public Destination Delivery { get; set; }

        /// <summary>
        /// Gets or sets the PrimaryCarrier.
        /// The primary carrier
        /// </summary>
        /// <value>
        /// The PrimaryCarrier.
        /// </value>
        [JsonProperty("primaryCarrier", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public Carrier PrimaryCarrier { get; set; }

        /// <summary>
        /// Gets or sets the SuccessiveCarriers.
        /// The list of successive carriers.
        /// </summary>
        /// <value>
        /// The SuccessiveCarriers.
        /// </value>
        [JsonProperty("successiveCarriers", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public IList<Carrier> SuccessiveCarriers { get; set; }

        /// <summary>
        /// Gets or sets the GoodsText.
        /// The Goods as free formatted text.
        /// </summary>
        /// <value>
        /// The GoodsText.
        /// </value>
        [JsonProperty("goodsText", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string GoodsText { get; set; }

        /// <summary>
        /// Gets or sets the GoodsInformation.
        /// Additional unstructured informational text that will be displayed above the list of goods.
        /// </summary>
        /// <value>
        /// The GoodsInformation.
        /// </value>
        [JsonProperty("goodsInformation", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string GoodsInformation { get; set; }

        /// <summary>
        /// Gets or sets the CarrierReservationInformation.
        /// Additional informational text to be displayed in the reservations field of a consignment note.
        /// </summary>
        /// <value>
        /// The CarrierReservationInformation.
        /// </value>
        [JsonProperty("carrierReservationInformation", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string CarrierReservationInformation { get; set; }

        /// <summary>
        /// Gets or sets the Goods.
        /// The Goods as product lines.
        /// </summary>
        /// <value>
        /// The Goods.
        /// </value>
        [JsonProperty("goods", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public IList<Product> Goods { get; set; }

        /// <summary>
        /// Gets or sets the DangerousGoods.
        /// The list of dangerous goods transported.
        /// </summary>
        /// <value>
        /// The DangerousGoods.
        /// </value>
        [JsonProperty("dangerousGoods", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public IList<DangerousGood> DangerousGoods { get; set; }

        /// <summary>
        /// Gets or sets the TransportationCosts.
        /// </summary>
        /// <value>
        /// The TransportationCosts.
        /// </value>
        [JsonProperty("transportationCosts", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string TransportationCosts { get; set; }

        /// <summary>
        /// Gets or sets the CarriagePaid.
        /// </summary>
        /// <value>
        /// The CarriagePaid.
        /// </value>
        [JsonProperty("carriagePaid", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public bool? CarriagePaid { get; set; }

        /// <summary>
        /// Gets or sets the CarriageForward.
        /// </summary>
        /// <value>
        /// The CarriageForward.
        /// </value>
        [JsonProperty("carriageForward", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public bool? CarriageForward { get; set; }

        /// <summary>
        /// Gets or sets the Reimbursement.
        /// </summary>
        /// <value>
        /// The Reimbursement.
        /// </value>
        [JsonProperty("reimbursement", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public CurrencyAmount Reimbursement { get; set; }

        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        /// <value>
        /// The State.
        /// </value>
        [Required]
        [JsonProperty("state")]
        [DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public State State { get; set; }

        /// <summary>
        /// Gets or sets the TransportOrderState.
        /// </summary>
        /// <value>
        /// The TransportOrderState.
        /// </value>
        [Required]
        [JsonProperty("transportOrderState")]
        [DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public TransportOrderState TransportOrderState { get; set; }

        /// <summary>
        /// Gets or sets the Attachments.
        /// A collection of uri's other documents related to this consignment note.
        /// </summary>
        /// <value>
        /// The Attachments.
        /// </value>
        [JsonProperty("attachments", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public IList<TransportDocumentAttachment> Attachments { get; set; }

        /// <summary>
        /// Gets or sets the Empties.
        /// Registration of empties delivered and returned.
        /// </summary>
        /// <value>
        /// The Empties.
        /// </value>
        [JsonProperty("empties", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public IList<EmptiesItem> Empties { get; set; }

        /// <summary>
        /// Gets or sets the Contacts.
        /// Other parties involved.
        /// </summary>
        /// <value>
        /// The Contacts.
        /// </value>
        [JsonProperty("contacts", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public IList<RelatedContact> Contacts { get; set; }

        /// <summary>
        /// Gets or sets the Reservations.
        /// Reservations made by the carrier or other parties at pickup or delivery of the goods.
        /// These can only be added if the document has been issued.
        /// </summary>
        /// <value>
        /// The Reservations.
        /// </value>
        [JsonProperty("reservations", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public IList<TransportDocumentComment> Reservations { get; set; }

        /// <summary>
        /// Gets or sets the TransportExecutions.
        /// The details for execution of the transport order by the driver. This includes the details 
        /// on the driver, the truck and/or trailer.
        /// </summary>
        /// <value>
        /// The TransportExecutions.
        /// </value>
        [JsonProperty("transportExecutions", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public IList<TransportExecution> TransportExecutions { get; set; }

        /// <summary>
        /// Gets or sets the ECmr.
        /// Indicates if this transportdocument should be issued as a digital transportdocument for digital signing.
        /// </summary>
        /// <value>
        /// The ECmr.
        /// </value>
        [JsonProperty("eCmr", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public bool? ECmr { get; set; }

        /// <summary>
        /// Gets or sets the Incoterms.
        /// </summary>
        /// <value>
        /// The Incoterms.
        /// </value>
        [JsonProperty("incoterms", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string Incoterms { get; set; }

    }
}
