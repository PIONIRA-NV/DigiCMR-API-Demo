  
//-----------------------------------------------------------------------
// <copyright file="Destination.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace  Xynaps.Api.Models
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    /// <summary>
    /// 
    /// </summary>
    public partial class Destination: IContact
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Destination"/> class.
        /// </summary>
        public Destination()
        {
        }
    }
}
