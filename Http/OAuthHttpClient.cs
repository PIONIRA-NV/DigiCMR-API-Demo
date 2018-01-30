//-----------------------------------------------------------------------
// <copyright file="OAuthHttpClient.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
// <summary></summary>
//-----------------------------------------------------------------------

namespace DigiCMR.Framework.Service
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// An HttpClient to make OAuth 2.0 secured API calls.
    /// </summary>
    /// <seealso cref="System.Net.Http.HttpClient" />
    public class OAuthHttpClient : HttpClient
    {
        /// <summary>
        /// The token cache
        /// </summary>
        private static TokenCache tokenCache = new TokenCache();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthHttpClient"/> class.
        /// </summary>
        public OAuthHttpClient()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthHttpClient" /> class.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public OAuthHttpClient(OAuth2Settings settings)
            : base()
        {
            this.Settings = settings;
        }

        /// <summary>
        /// Gets or sets the settings.
        /// </summary>
        /// <value>The settings.</value>
        public OAuth2Settings Settings { get; set; }

        /// <summary>
        /// Clears the token cache.
        /// </summary>
        public void ClearTokenCache()
        {
            TokenResponse token;
            tokenCache.TryRemove(this.Settings.ClientId, out token);
        }

        /// <summary>
        /// Gets the token.
        /// </summary>
        /// <returns>A token response</returns>
        public async Task<TokenResponse> GetTokenAsync()
        {
            TokenResponse token;
            if (tokenCache.TryGetValue(this.Settings.ClientId, out token)
                && (token != null && token.Expires > DateTime.UtcNow))
            {
                return token;
            }

            try
            {
                if (token == null || !token.IsValid)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        Dictionary<string, string> parameters;
                        if (token != null && !string.IsNullOrEmpty(token.RefreshToken) && !string.IsNullOrEmpty(this.Settings.AccessTokenUrl))
                        {
                            parameters = new Dictionary<string, string>()
                            {
                                { "client_id", this.Settings.ClientId },
                                { "client_secret", this.Settings.ClientSecret },
                                { "grant_type", "refresh_token" },
                                { "refresh_token", token.RefreshToken }
                            };
                        }
                        else
                        {
                            parameters = new Dictionary<string, string>()
                            {
                                { "client_id", this.Settings.ClientId },
                                { "client_secret", this.Settings.ClientSecret },
                                { "grant_type", "client_credentials" }
                            };
                        }

                        var response = await client.PostAsync(this.Settings.AccessTokenUrl, new FormUrlEncodedContent(parameters)).ConfigureAwait(false);
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                           var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                            token = JsonConvert.DeserializeObject<TokenResponse>(content);
                            token.Expires = DateTime.UtcNow.AddSeconds((double)token.ExpiresIn);

                            tokenCache.AddOrUpdate(this.Settings.ClientId, token, (s, t) => { return token; });

                            return token;
                        }
                        else
                        {
                            // Fallback to basic auth.
                            var bytes = Encoding.Unicode.GetBytes(this.Settings.ClientId + ":" + this.Settings.ClientSecret);
                            var credentials = Convert.ToBase64String(bytes);
                            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);

                            response = await client.GetAsync(this.Settings.BaseUrl + "/oauth2/signin/").ConfigureAwait(false);
                            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                                token = JsonConvert.DeserializeObject<TokenResponse>(content);
                                token.Expires = DateTime.UtcNow.AddSeconds((double)token.ExpiresIn);

                                tokenCache.AddOrUpdate(this.Settings.ClientId, token, (s, t) => { return token; });

                                return token;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Tracing.TraceError(4001, "Failed to retrieve token. " + ex.Message);
            }

            return null;
        }

        /// <summary>
        /// Posts the json asynchronous.
        /// </summary>
        /// <param name="uri">The URL.</param>
        /// <param name="value">The value.</param>
        /// <returns>The HTTP response message</returns>
        public async Task<HttpResponseMessage> PostJsonAsync(Uri uri, object value)
        {
            await this.SetTokenAsync().ConfigureAwait(false);
            this.DefaultRequestHeaders.Accept.Clear();
            this.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var content = new StringContent(JsonConvert.SerializeObject(value), Encoding.UTF8, "application/json");

            return await this.PostAsync(uri, content).ConfigureAwait(false);
        }

        /// <summary>
        /// post json as an asynchronous operation.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="uri">The URI.</param>
        /// <param name="value">The value.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        public async Task<T> PostJsonAsync<T>(Uri uri, object value)
        {
            HttpResponseMessage response = await this.PostJsonAsync(uri, value);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var responsecontent = await response.Content.ReadAsStringAsync().ConfigureAwait(false); ;
                if (!string.IsNullOrEmpty(responsecontent))
                {
                    return JsonConvert.DeserializeObject<T>(responsecontent);
                }
            }

            return default(T);
        }

        /// <summary>
        /// Send an HTTP request as an asynchronous operation.
        /// </summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the
        /// asynchronous operation.</returns>
        public async Task SetTokenAsync()
        {
            TokenResponse token = await this.GetTokenAsync().ConfigureAwait(false);
            if (token != null)
            {
                this.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);
            }
            else
            {
                Tracing.TraceInformation("SetTokenAsync failed to set an access token. Fallback to basic authentication.");
                var bytes = Encoding.Default.GetBytes(this.Settings.ClientId + ":" + this.Settings.ClientSecret);
                var credentials = Convert.ToBase64String(bytes);
                this.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);
            }
        }

        /// <summary>
        /// Sends a HTTP Get and deserializes the result as an instance of type T.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="uri">The URI.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        public async Task<T> GetAsync<T>(string uri)
        {
            await this.SetTokenAsync().ConfigureAwait(false);
            HttpResponseMessage response = await this.GetAsync(uri).ConfigureAwait(false);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                if (!string.IsNullOrEmpty(content))
                {
                    return JsonConvert.DeserializeObject<T>(content);
                }
            }

            return default(T);
        }
    }
}