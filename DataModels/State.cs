//-----------------------------------------------------------------------
// <copyright file="State.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Xynaps.Api.Models
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public enum State
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// New
        /// </summary>
        New = 1,

        /// <summary>
        /// Draft
        /// </summary>
        Draft = 2,

        /// <summary>
        /// Issued
        /// </summary>
        Issued = 3,

        /// <summary>
        /// SignedForPickup
        /// </summary>
        SignedForPickup = 4,

        /// <summary>
        /// SignedForDelivery
        /// </summary>
        SignedForDelivery = 5,

        /// <summary>
        /// Completed
        /// </summary>
        Completed = 6,

        /// <summary>
        /// The document was cancelled
        /// </summary>
        Cancelled = 8
    }
}
