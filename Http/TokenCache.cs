//-----------------------------------------------------------------------
// <copyright file="TokenCache.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DigiCMR.Framework.Service
{
    using System.Collections.Concurrent;

    /// <summary>
    /// A threadsafe token cache
    /// </summary>
    /// <seealso cref="ConcurrentDictionary{String, TokenResponse}"/>
    public class TokenCache : ConcurrentDictionary<string, TokenResponse>
    {
    }
}