//-----------------------------------------------------------------------
// <copyright file="Application.cs" company="PIONIRA NV">
//     Copyright (c) PIONIRA NV. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DigiCMRApi
{
    using System;
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;

    /// <summary>
    /// Class Console Application.
    /// </summary>
    public static class ConsoleApp
    {
        /// <summary>
        /// Gets or sets the menu actions.
        /// </summary>
        /// <value>The menu actions.</value>
        public static Collection<MenuAction> MenuActions { get; set; }

        /// <summary>
        /// Asks the date time.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>System.Nullable&lt;DateTime&gt;.</returns>
        public static DateTime? AskDateTime(string message)
        {
            string idValue = AskStringValue(message);
            DateTime date;
            if (DateTime.TryParse(idValue, out date))
            {
                return date;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Asks the identifier.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>System.Nullable&lt;System.Int64&gt;.</returns>
        public static long? AskId(string message)
        {
            string idValue = AskStringValue(message);
            long id;
            if (long.TryParse(idValue, out id))
            {
                return id;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Asks the string value.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>System.String.</returns>
        public static string AskStringValue(string message)
        {
            Console.Write(message + " : ");

            return Console.ReadLine();
        }

        /// <summary>
        /// Runs this instance.
        /// </summary>
        public static async Task Run()
        {
            int choice = 1;
            while (choice != 0)
            {
                for (int i = 0; i < MenuActions.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {MenuActions[i].Title}");
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("0. Quit");
                Console.WriteLine("Input: ");

                var input = Console.ReadLine();
                if (int.TryParse(input, out choice) && choice > 0 && choice <= MenuActions.Count)
                {
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine(MenuActions[choice - 1].Title);
                    Console.WriteLine("----------------------------------------------------------------------------");
                    await MenuActions[choice - 1].Action();
                }
            }
        }
    }
}