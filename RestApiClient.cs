//-----------------------------------------------------------------------
// <copyright file="RestApiDemo.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DigiCMRApi
{
    using DigiCMR.Framework.Service;
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using Xynaps.Api.Models;

    /// <summary>
    /// Class DigiCMRApiDemo.
    /// </summary>
    /// <seealso cref="DigiCMRApi.IDigiCMRApiDemo" />
    public class RestApiDemo : IDigiCMRApiDemo
    {
        /// <summary>
        /// The oauth settings
        /// </summary>
        private readonly OAuth2Settings oauthSettings;

        /// <summary>
        /// The http client
        /// </summary>
        private OAuthHttpClient client;

        /// <summary>
        /// Initializes a new instance of the <see cref="RestApiDemo" /> class.
        /// </summary>
        public RestApiDemo(string clientId, string clientSecret)
        {
            this.oauthSettings = new OAuth2Settings
            {
                ClientId = clientId,
                ClientSecret = clientSecret,
                AccessTokenUrl = "https://apps.xynapos.net/api/v1/oauth2/token",
                BaseUrl = "https://apps.xynaps.net/"
            };

            this.client = new OAuthHttpClient(this.oauthSettings);
        }

        /// <summary>
        /// Creates the transport document.
        /// </summary>
        /// <returns>Task.</returns>
        public async Task CreateTransportDocument()
        {
            var dossierNumber = ConsoleApp.AskStringValue("DossierNumber");
            var externalId = ConsoleApp.AskStringValue("ExternalId");

            TransportDocument newDocument = new TransportDocument
            {
                DossierNumber = dossierNumber,
                ExternalId = externalId,
                IssuedDate = DateTime.Today,
                Consignor = new Contact
                {
                    ExternalId = "14-14",
                    Name = "ACME Bakeries",
                    Address = new Address
                    {
                        StreetAddress = "Baron de Maerelaan 8",
                        City = "Zeebrugge",
                        Postalcode = "8380",
                    },
                    // Use the signature text to provide the information to put into field 14 of the CMR
                    SignatureText = "ACME Bakeries"
                },
                PrimaryCarrier = new Carrier
                {
                    ExternalId = "16-16",
                    Name = "PIONIRA",
                    Address = new Address
                    {
                        StreetAddress = "Baron de Maerelaan 15",
                        City = "Zeebrugge",
                        Postalcode = "8380"
                    },
                    License = "9999999",
                    // Use the signature text to provide the information to put into field 15 of the CMR
                    SignatureText = "Transport PIONIRA"
                },
                Consignee = new Contact
                {
                    ExternalId = "15-15",
                    Name = "ACME Warehouse",
                    Address = new Address
                    {
                        StreetAddress = "Baron de Maerelaan 8",
                        City = "Gent",
                        Postalcode = "9000"
                    }
                },
                TransportExecutions = new TransportExecution[]
                {
                    new TransportExecution
                    {
                        Driver = new Driver
                        {
                            Name = "John Doe",
                            ExternalId = "JOHNDOE_42"
                        },
                        Truck = new Vehicle
                        {
                            ExternalId = "12345",
                            LicensePlate = "5-JNK-736"
                        },
                        Trailer = new Vehicle
                        {
                            ExternalId = "67890",
                            LicensePlate = "5-TRV-368"
                        },
                    }
                },
                //GoodsText = "2 pal. bruin brood",
                Goods = new Product[]
                {
                    new Product
                    {
                        Code = "Code",
                        Description = "u",
                        LotNumber = "-",
                        Quantity = 5,
                        Reference = "8",
                        SealNumber = "Sealnr",
                        ExternalId = "4646",
                    },
                    new Product
                    {
                        Code = "Code2",
                        SealNumber = "Sealnr",
                        ExternalId = "422646",
                    }
                },
                ECmr = true
            };

            TransportDocumentReturnState state = await this.client.PostJsonAsync<TransportDocumentReturnState>(new Uri(this.oauthSettings.BaseUrl + "/api/v2/transportdocuments"), newDocument);
            if (state != null)
            {
                Console.WriteLine("CMR succesfully created!");
                DumpReturnState(state);
            }
        }

        /// <summary>
        /// Creates the transport document attachment.
        /// </summary>
        /// <returns>Task.</returns>
        public async Task CreateTransportDocumentAttachment()
        {
            long? id = ConsoleApp.AskId("Enter the Id of the CMR for which to upload the attachment");
            if (id.HasValue)
            {
                var externalId = ConsoleApp.AskStringValue("ExternalId");
                string path = ConsoleApp.AskStringValue("Enter the file name to the attachment to upload");
                if (!File.Exists(path))
                {
                    Console.WriteLine("File {0} does not exist", path);

                    return;
                }

                byte[] buffer = File.ReadAllBytes(path);
                string content = Convert.ToBase64String(buffer);

                var attachment = new TransportDocumentAttachment
                {
                    ExternalId = externalId,
                    DisplayName = Path.GetFileNameWithoutExtension(path),
                    Filename = Path.GetFileName(path),
                    Content = content,
                    MimeType = System.Web.MimeMapping.GetMimeMapping(path),
                    Type = "Delivery Note"
                };

                var response = await this.client.PostJsonAsync<TransportDocumentReturnState>(
                    new Uri($"{this.oauthSettings.BaseUrl}/api/v2/transportdocuments/{id.Value}/attachments"),
                    attachment);

                Console.WriteLine("Attachment created with id: {0}", response.Id);
            }
        }

        /// <summary>
        /// Get the first 10 the transport documents.
        /// </summary>
        /// <returns>Task.</returns>
        public async Task Get10TransportDocuments()
        {
            TransportDocument[] transportDocuments = await GetTransportDocuments("page=1&size=10");
            if (transportDocuments != null && transportDocuments.Length > 0)
            {
                foreach (var transportDocument in transportDocuments)
                {
                    Console.WriteLine("CMR with ID " + transportDocument.Id.ToString() + " succesfully retrieved!");
                }
            }
        }

        /// <summary>
        /// Gets the transport document.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task&lt;TransportDocument&gt;.</returns>
        public Task<TransportDocument> GetTransportDocument(long id)
        {
            return this.client.GetAsync<TransportDocument>($"{this.oauthSettings.BaseUrl}api/v2/transportdocuments/{id}");
        }

        /// <summary>
        /// Gets the transport document.
        /// </summary>
        /// <returns>Task.</returns>
        public async Task GetTransportDocument()
        {
            long? id = ConsoleApp.AskId("Enter the Id of the CMR to retrieve");
            if (id.HasValue)
            {
                TransportDocument transportDocument = await this.GetTransportDocument(id.Value);
                if (transportDocument != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("CMR with ID " + transportDocument.Id.ToString() + " succesfully retrieved!");
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("CMR with ID {0} not found!", id);
                }
            }
        }

        /// <summary>
        /// Gets the transport document as PDF.
        /// </summary>
        /// <returns>Task.</returns>
        public async Task GetTransportDocumentAsPdf()
        {
            long? id = ConsoleApp.AskId("Enter the Id of the CMR to retrieve");
            if (id.HasValue)
            {
                string url = $"{this.oauthSettings.BaseUrl}api/v2/transportdocuments/{id.Value.ToString()}";
                await this.client.SetTokenAsync();
                this.client.DefaultRequestHeaders.Accept.Clear();
                this.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/pdf"));
                HttpResponseMessage response = await this.client.GetAsync(url);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Console.WriteLine();
                    Console.WriteLine($"CMR with ID {id.ToString()} succesfully retrieved as pdf!");
                    Console.WriteLine();
                    Console.WriteLine();

                    byte[] content = await response.Content.ReadAsByteArrayAsync();
                    if (content != null)
                    {
                        System.IO.File.WriteAllBytes("c:\\ecmr.pdf", content);
                        Process.Start("c:\\ecmr.pdf");
                    }
                }
                else
                {
                    Console.WriteLine($"CMR with ID {id} not found!");
                }
            }
        }

        /// <summary>
        /// Gets the transport document attachments.
        /// </summary>
        /// <returns>Task.</returns>
        public async Task GetTransportDocumentAttachments()
        {
            long? id = ConsoleApp.AskId("Enter the Id of the CMR for which to retrieve the attachments");
            if (id.HasValue)
            {
                var attachments = await this.client.GetAsync<TransportDocumentAttachment[]>($"{this.oauthSettings.BaseUrl}/api/v2/transportdocuments/{id.Value}/attachments");
                foreach (var attachment in attachments)
                {
                    Console.WriteLine("{0} - {1}: {2}", attachment.Id, attachment.DisplayName, attachment.Uri);
                }
            }
        }

        /// <summary>
        /// Gets the transport document by external identifier.
        /// </summary>
        /// <returns>Task.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task GetTransportDocumentByExternalId()
        {
            string id = ConsoleApp.AskStringValue("Enter the external Id of the CMR to retrieve");
            if (!string.IsNullOrEmpty(id))
            {
                var result = await GetTransportDocuments($"filter=externalId eq \"{id}\"");
                TransportDocument transportDocument = result.FirstOrDefault();
                if (transportDocument != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("CMR with ID " + transportDocument.Id.ToString() + " succesfully retrieved!");
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("CMR with ID {0} not found!", id);
                }
            }
        }

        /// <summary>
        /// Gets the transport documents.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>Task&lt;TransportDocument[]&gt;.</returns>
        public Task<TransportDocument[]> GetTransportDocuments(string query)
        {
            string url = this.oauthSettings.BaseUrl + "api/v2/transportdocuments";
            if (!string.IsNullOrEmpty(query))
            {
                url += "?" + query;
            }

            return this.client.GetAsync<TransportDocument[]>(url);
        }

        /// <summary>
        /// Gets the transport document states.
        /// </summary>
        /// <returns>Task.</returns>
        public async Task GetTransportDocumentStates()
        {
            long? id = ConsoleApp.AskId("Enter the Id of the CMR for which to retrieve the state");
            if (id.HasValue)
            {
                var states = await this.client.GetAsync<TransportDocumentReturnState[]>($"{this.oauthSettings.BaseUrl}/api/v2/transportdocuments/states?ids={id.Value}");
                DumpStates(states);
            }
        }

        /// <summary>
        /// Gets the transport document states since.
        /// </summary>
        /// <returns>Task.</returns>
        public async Task GetTransportDocumentStatesSince()
        {
            DateTime? date = ConsoleApp.AskDateTime("Retrieve the document states changed since (yyyy-MM-ddTHH:mm:ss) ");
            if (date.HasValue)
            {
                var states = await this.client.GetAsync<TransportDocumentReturnState[]>($"{this.oauthSettings.BaseUrl}/api/v2/transportdocuments/states?since={date.Value:s}&page=1&size=10");
                DumpStates(states);
            }
        }

        /// <summary>
        /// Issues the transport document.
        /// </summary>
        /// <returns>Task.</returns>
        public async Task IssueTransportDocument()
        {
            long? id = ConsoleApp.AskId("Enter the Id of the CMR to issue.");
            if (id.HasValue)
            {
                var state = await this.client.PostJsonAsync<TransportDocumentReturnState>(new Uri($"{this.oauthSettings.BaseUrl}/api/v2/transportdocuments/{id.Value}/issue"), null);

                DumpReturnState(state);
            }
        }

        /// <summary>
        /// Prints the transport document.
        /// </summary>
        /// <returns>Task.</returns>
        public Task PrintTransportDocument()
        {
            long? id = ConsoleApp.AskId("Enter the Id of the CMR to print.");
            if (id.HasValue)
            {
                // TBD
            }

            return Task.FromResult(0);
        }

        /// <summary>
        /// Updates the transport document.
        /// </summary>
        /// <returns>Task.</returns>
        public async Task UpdateTransportDocument()
        {
            var id = ConsoleApp.AskId("Enter the Id of the CMR to update");

            TransportDocument newDocument = new TransportDocument
            {
                Id = id,
                TransportExecutions = new TransportExecution[]
                {
                    new TransportExecution
                    {
                        Driver = new Driver
                        {
                            Name = "John Doe 3",
                            ExternalId = "JOHNDOE_12"
                        },
                        Truck = new Vehicle
                        {
                            ExternalId = "123459",
                            LicensePlate = "5-JNK-716"
                        },
                        Trailer = new Vehicle
                        {
                            ExternalId = "678990",
                            LicensePlate = "5-TRV-388"
                        },
                    }
                }
            };

            var state = await this.client.PostJsonAsync<TransportDocumentReturnState>(new Uri(this.oauthSettings.BaseUrl + "/api/v2/transportdocuments"), newDocument);
            if (state != null)
            {
                Console.WriteLine("CMR succesfully created!");
                DumpReturnState(state);
            }
        }

        /// <summary>
        /// Dumps the state of the return.
        /// </summary>
        /// <param name="state">The state.</param>
        private static void DumpReturnState(TransportDocumentReturnState state)
        {
            Console.WriteLine("CMR Number     : " + state.CmrNumber);
            Console.WriteLine("CMR Id         : " + state.Id);
            Console.WriteLine("CMR ExternalId : " + state.ExternalId);
            Console.WriteLine("CMR State      : " + state.State);
        }

        /// <summary>
        /// Dumps the states.
        /// </summary>
        /// <param name="states">The states.</param>
        private static void DumpStates(TransportDocumentReturnState[] states)
        {
            if (states != null)
            {
                foreach (var state in states)
                {
                    DumpReturnState(state);
                    Console.WriteLine();
                }
            }
        }
    }
}