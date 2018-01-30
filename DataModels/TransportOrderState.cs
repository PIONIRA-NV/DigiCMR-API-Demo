//-----------------------------------------------------------------------
// <copyright file="TransportOrderState.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Xynaps.Api.Models
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public enum TransportOrderState
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
        /// Started
        /// </summary>
        Started = 2,

        /// <summary>
        /// ArrivedAtPickup
        /// </summary>
        ArrivedAtPickup = 3,

        /// <summary>
        /// Loading
        /// </summary>
        Loading = 4,

        /// <summary>
        /// Loaded
        /// </summary>
        Loaded = 5,

        /// <summary>
        /// ArrivedAtDelivery
        /// </summary>
        ArrivedAtDelivery = 6,

        /// <summary>
        /// Unloading
        /// </summary>
        Unloading = 7,

        /// <summary>
        /// Unloaded
        /// </summary>
        Unloaded = 8,

        /// <summary>
        /// Completed
        /// </summary>
        Completed = 9,

    }
}
