//-----------------------------------------------------------------------
// <copyright file="Product.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Xynaps.Api.Models
{
    using Newtonsoft.Json;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class Product.
    /// </summary>
    /// <seealso cref="System.IEquatable{Xynaps.Api.Models.Product}" />
    public partial class Product
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// </summary>
        public Product()
        {
            this.Quantity = 0;
        }

        /// <summary>
        /// Gets or sets the packaging description.
        /// </summary>
        /// <value>The packaging description.</value>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("packagingDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string PackagingDescription { get; set; }

        /// <summary>
        /// Gets or sets the seal number.
        /// </summary>
        /// <value>The seal number.</value>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("sealNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string SealNumber { get; set; }
    }
}