//-----------------------------------------------------------------------
// <copyright file="EntityState.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Xynaps.Api.Models
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public enum EntityState
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Added
        /// </summary>
        Added = 1,

        /// <summary>
        /// Deleted
        /// </summary>
        Deleted = 2,

        /// <summary>
        /// Modified
        /// </summary>
        Modified = 3,

    }
}
