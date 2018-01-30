//-----------------------------------------------------------------------
// <copyright file="SignOffState.cs" company="PIONIRA NV">
//     Copyright (c) 2015 PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Xynaps.Api.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the states in the sign off process.
    /// </summary>
    public enum SignOffState
    {
        /// <summary>
        /// The none
        /// </summary>
        None = 0,

        /// <summary>
        /// The driver signs off for pickup
        /// </summary>
        DriverSignOffForPickup = 1,

        /// <summary>
        /// The consignor signs off for pickup
        /// </summary>
        ConsignorSignOffForPickup = 2,

        /// <summary>
        /// The driver signs off for delivery
        /// </summary>
        DriverSignOffForDelivery = 3,

        /// <summary>
        /// The consignee signs off for delivery
        /// </summary>
        ConsigneeSignOffForDelivery = 4,

        /// <summary>
        /// The sign off process is completed
        /// </summary>
        SignOffCompleted = 5
    }
}
