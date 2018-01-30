  
//-----------------------------------------------------------------------
// <copyright file="DocumentProperties.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace  Xynaps.Api.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// 
    /// </summary>
    public partial class DocumentProperties
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentProperties"/> class.
        /// </summary>
        public DocumentProperties()
        {
            this.CountryLayout = "BE";
            this.Pages = 4;
            this.DocumentTypeId = 1;
        }

        [JsonProperty("documentTypeId", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember]
        public int DocumentTypeId { get; set; }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode() => base.GetHashCode();
    }
}
