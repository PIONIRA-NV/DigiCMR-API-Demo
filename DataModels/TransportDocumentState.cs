//-----------------------------------------------------------------------
// <copyright file="TransportDocumentState.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace  Xynaps.Api.Models
{
    using System;

    /// <summary>
    /// </summary>
    public enum TransportDocumentState
    {
        /// <summary>
        /// No value.
        /// </summary>
        None = 0,

        /// <summary>
        /// </summary>
        Draft = 2,

        /// <summary>
        /// </summary>
        Issued = 3,

        /// <summary>
        /// </summary>
        SignedForPickup = 4,

        /// <summary>
        /// </summary>
        SignedForDelivery = 5,

    }
}
