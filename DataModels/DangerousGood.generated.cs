//-----------------------------------------------------------------------
// <copyright file="DangerousGood.cs" company="PIONIRA NV">
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
    [XmlRootAttribute("DangerousGood", Namespace = "https://www.pionira.be/api/v2", IsNullable = false)]
    [GeneratedCode("PIONIRA RAML Server Generator", "1.0.0.0")]
    public partial class DangerousGood
    {
        /// <summary>
        /// Gets or sets the Code.
        /// The UN dangerous good code, prefixed with the characters 'UN'
        /// </summary>
        /// <value>
        /// The Code.
        /// </value>
        [Required]
        [JsonProperty("code")]
        [DataMember]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the TechnicalName.
        /// </summary>
        /// <value>
        /// The TechnicalName.
        /// </value>
        [Required]
        [JsonProperty("technicalName")]
        [DataMember]
        public string TechnicalName { get; set; }

        /// <summary>
        /// Gets or sets the PackagingDangerLevelCode.
        /// The code classifying the level of danger of the good.
        /// </summary>
        /// <value>
        /// The PackagingDangerLevelCode.
        /// </value>
        [Required]
        [JsonProperty("packagingDangerLevelCode")]
        [DataMember]
        public string PackagingDangerLevelCode { get; set; }

    }
}
