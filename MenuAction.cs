//-----------------------------------------------------------------------
// <copyright file="MenuAction.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DigiCMRApi
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Class MenuAction.
    /// </summary>
    public class MenuAction 
    {
        /// <summary>
        /// Gets or sets the action.
        /// </summary>
        /// <value>The action.</value>
        public Func<Task> Action { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }
    }
}