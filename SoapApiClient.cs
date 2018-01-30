//-----------------------------------------------------------------------
// <copyright file="SoapApiDemo.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DigiCMRApi
{
    using Service;
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Threading.Tasks;

    /// <summary>
    /// Class SoapApiDemo.
    /// </summary>
    /// <seealso cref="DigiCMRApi.IDigiCMRApiDemo" />
    public class SoapApiDemo : IDigiCMRApiDemo
    {
        /// <summary>
        /// The SOAP client
        /// </summary>
        private TransportDocumentServiceClient soapClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="DigiCMRApiDemo" /> class.
        /// </summary>
        public SoapApiDemo()
        {
            this.soapClient = new Service.TransportDocumentServiceClient("BasicHttpsBinding_ITransportDocumentService");
            this.soapClient.ClientCredentials.UserName.UserName = "";
            this.soapClient.ClientCredentials.UserName.Password = "";
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
                GoodsText = "2 pal. bruin brood",
                Goods = new Product[]
                {
                    new Product
                    {
                        Code = "Code",
                        SealNumber = "Sealnr",
                        ExternalId = "4646",
                    }
                },
                ECmr = true
            };

            TransportDocumentReturnState state = await this.soapClient.CreateTransportDocumentAsync(newDocument);
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

                var response = await this.soapClient.CreateTransportDocumentAttachmentsAsync(id.Value, attachment);

                Console.WriteLine("Attachment created with id: {0}", response.Id);
            }
        }

        /// <summary>
        /// Get10s the transport documents.
        /// </summary>
        /// <returns>Task.</returns>
        public async Task Get10TransportDocuments()
        {
            TransportDocument[] transportDocuments = await this.soapClient.GetTransportDocumentsAsync(null, 1, 10);
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
        /// <returns>Task.</returns>
        public async Task GetTransportDocument()
        {
            long? id = ConsoleApp.AskId("Enter the Id of the CMR to retrieve");
            if (id.HasValue)
            {
                TransportDocument transportDocument = await this.soapClient.GetTransportDocumentByIdAsync(id.Value);
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
                TransportDocumentAttachment transportDocumentPdf = await this.soapClient.GetTransportDocumentAsPdfAsync(id.Value);
                if (transportDocumentPdf != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("CMR with ID " + transportDocumentPdf.Id.ToString() + " succesfully retrieved as pdf!");
                    Console.WriteLine();
                    Console.WriteLine();

                    byte[] content = Convert.FromBase64String(transportDocumentPdf.Content);
                    if (content != null)
                    {
                        string path = System.IO.Path.GetTempFileName() + ".pdf";
                        File.WriteAllBytes(path, content);
                        Process.Start(path);
                    }
                }
                else
                {
                    Console.WriteLine("CMR with ID {0} not found!", id);
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
                var attachments = await this.soapClient.GetTransportDocumentAttachmentsAsync(id.Value);
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
        public async Task GetTransportDocumentByExternalId()
        {
            string id = ConsoleApp.AskStringValue("Enter the external Id of the CMR to retrieve");
            if (!string.IsNullOrEmpty(id))
            {
                TransportDocument transportDocument = await this.soapClient.GetTransportDocumentByExternalIdAsync(id);
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
        /// Gets the transport document states.
        /// </summary>
        /// <returns>Task.</returns>
        public async Task GetTransportDocumentStates()
        {
            long? id = ConsoleApp.AskId("Enter the Id of the CMR for which to retrieve the state");
            if (id.HasValue)
            {
                var states = await this.soapClient.GetTransportDocumentStateByIdsAsync(new long[] { id.Value }, 1, 10);
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
                var states = await this.soapClient.GetTransportDocumentStateSinceAsync(date.Value, 1, 10);
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
                var document = await this.soapClient.GetTransportDocumentByIdAsync(id.Value);
                document.State = State.Issued;
                var state = await this.soapClient.UpdateTransportDocumentAsync(document);

                DumpReturnState(state);
            }
        }

        /// <summary>
        /// Issues if necessary and sends a print request to the Xynaps Agent.
        /// </summary>
        /// <returns>Task.</returns>
        public async Task PrintTransportDocument()
        {
            long? id = ConsoleApp.AskId("Enter the Id of the CMR to print.");
            if (id.HasValue)
            {
                var document = await this.soapClient.PrintTransportDocumentAsync(id.Value, "Microsoft XPS Document Writer");

                DumpReturnState(document);
            }
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

            TransportDocumentReturnState state = await this.soapClient.CreateTransportDocumentAsync(newDocument);
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
            Console.WriteLine();
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