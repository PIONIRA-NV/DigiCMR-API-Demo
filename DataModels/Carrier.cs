//-----------------------------------------------------------------------
// <copyright file="Carrier.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Xynaps.Api.Models
{
    using Newtonsoft.Json;
    using System.Runtime.Serialization;

    /// <summary>
    ///
    /// </summary>
    public partial class Carrier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Carrier"/> class.
        /// </summary>
        public Carrier()
        {
        }

        /// <summary>
        /// Gets or sets the LicensePlate.
        /// </summary>
        /// <value>
        /// The LicensePlate.
        /// </value>
        [JsonProperty("trailerLicensePlate", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember]
        public string TrailerLicensePlate { get; set; }
    }
}