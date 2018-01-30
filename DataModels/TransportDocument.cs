//-----------------------------------------------------------------------
// <copyright file="TransportDocument.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Xynaps.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    ///
    /// </summary>
    /// <tags>SOAP</tags>
    public partial class TransportDocument
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportDocument" /> class.
        /// </summary>
        public TransportDocument()
        {
        }

        /// <summary>
        /// Gets or sets the extra properties.
        /// </summary>
        /// <value>The extra properties.</value>
        [JsonProperty("extraProperties", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public Dictionary<string, string> ExtraProperties { get; set; }
    }
}