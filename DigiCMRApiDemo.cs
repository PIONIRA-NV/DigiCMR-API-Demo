//-----------------------------------------------------------------------
// <copyright file="DigiCMRApiDemo.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DigiCMRApi
{
    using Service;
    using System;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.IO;

    /// <summary>
    /// Class DigiCMRApiDemo.
    /// </summary>
    public class DigiCMRApiDemo
    {
        /// <summary>
        /// The REST client
        /// </summary>
        private IDigiCMRApiDemo apiDemo;

        /// <summary>
        /// Initializes a new instance of the <see cref="DigiCMRApiDemo" /> class.
        /// </summary>
        public DigiCMRApiDemo()
        {
            Console.WriteLine("1. Test SOAP API");
            Console.WriteLine("2. Test REST API");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("0. Quit");
            Console.WriteLine("Input: ");

            var input = Console.ReadLine();
            if (int.TryParse(input, out int choice) && choice > 0 && choice <= 2)
            {
                if (choice == 1)
                {
                    this.apiDemo = new SoapApiDemo();
                }
                else
                {
                    this.apiDemo = new RestApiDemo();
                }

                ConsoleApp.MenuActions = new Collection<MenuAction>
                {
                    new MenuAction { Title = "Create TransportDocument", Action = this.apiDemo.CreateTransportDocument },
                    new MenuAction { Title = "Update TransportDocument Driver", Action = this.apiDemo.UpdateTransportDocument },
                    new MenuAction { Title = "Retrieve TransportDocument", Action = this.apiDemo.GetTransportDocument },
                    new MenuAction { Title = "Retrieve transportdocument state", Action = this.apiDemo.GetTransportDocumentStates },
                    new MenuAction { Title = "Retrieve transportdocument states since ...", Action = this.apiDemo.GetTransportDocumentStatesSince },
                    new MenuAction { Title = "Issue a transportdocument", Action = this.apiDemo.IssueTransportDocument },
                    new MenuAction { Title = "Print a transportdocument", Action = this.apiDemo.PrintTransportDocument },
                    new MenuAction { Title = "Create a transportdocument attachment", Action = this.apiDemo.CreateTransportDocumentAttachment },
                    new MenuAction { Title = "Retrieve the transportdocument attachments", Action = this.apiDemo.GetTransportDocumentAttachments },
                    new MenuAction { Title = "Retrieve transportdocument as pdf", Action = this.apiDemo.GetTransportDocumentAsPdf },
                    new MenuAction { Title = "Retrieve first 10 transport documents", Action = this.apiDemo.Get10TransportDocuments }
                };

                Console.Clear();
            }
        }
    }
}