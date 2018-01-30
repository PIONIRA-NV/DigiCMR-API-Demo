//-----------------------------------------------------------------------
// <copyright file="TokenResponse.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace DigiCMR.Framework.Service
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// The token response retrurned from trhe Authorization server.
    /// </summary>
    public class TokenResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponse"/> class.
        /// </summary>
        public TokenResponse()
        {
        }

        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        /// <value>The token.</value>
        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the expiry date.
        /// </summary>
        /// <value>The expires.</value>
        public DateTime Expires { get; set; }

        /// <summary>
        /// Gets or sets the expires in.
        /// </summary>
        /// <value>The expires in.</value>
        [JsonProperty(PropertyName = "expires_in")]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// Returns true if the token is valid.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is valid; otherwise, <c>false</c>.
        /// </value>
        public bool IsValid
        {
            get
            {
                return !string.IsNullOrEmpty(this.AccessToken) && this.Expires > DateTime.UtcNow;
            }
        }

        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        /// <value>The token.</value>
        [JsonProperty(PropertyName = "refresh_token")]
        public string RefreshToken { get; set; }
    }
}