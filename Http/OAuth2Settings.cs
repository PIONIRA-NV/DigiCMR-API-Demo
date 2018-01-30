//-----------------------------------------------------------------------
// <copyright file="OAuth2Settings.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DigiCMR.Framework.Service
{
    using System;

    /// <summary>
    /// Represents the OAuth 2.0 Client settings
    /// </summary>
    [Serializable]
    public class OAuth2Settings
    {
        /// <summary>
        /// Gets the access token URL.
        /// </summary>
        /// <value>The access token URL.</value>
        public string AccessTokenUrl { get; internal set; }

        /// <summary>
        /// Gets or sets the base URL.
        /// </summary>
        /// <value>
        /// The base URL.
        /// </value>
        public string BaseUrl { get; set; }

        /// <summary>
        /// Gets or sets the connection key.
        /// </summary>
        /// <value>
        /// The connection key.
        /// </value>
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the connection secret.
        /// </summary>
        /// <value>
        /// The connection secret.
        /// </value>
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets the redirect URL.
        /// </summary>
        /// <value>The redirect URL.</value>
        public string RedirectUrl { get; internal set; }
    }
}