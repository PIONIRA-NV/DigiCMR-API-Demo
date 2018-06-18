//-----------------------------------------------------------------------
// <copyright file="Package.cs" company="PIONIRA NV">
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
    public partial class Package
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Package"/> class.
        /// </summary>
        public Package()
        {
        }

        /// <summary>
        /// Gets or sets the packaging details contained in this package.
        /// </summary>
        /// <value>
        /// The PackagingDetails.
        /// </value>
        [JsonProperty("packagingDetails", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public IList<Package> PackagingDetails { get; set; }
    }
}