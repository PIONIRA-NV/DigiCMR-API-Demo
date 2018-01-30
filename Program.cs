//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DigiCMRApi
{
    using System;

    /// <summary>
    /// Class Program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        private static void Main(string[] args)
        {
            DigiCMRApiDemo demo = new DigiCMRApiDemo();
            ConsoleApp.Run().Wait();
        }
    }
}