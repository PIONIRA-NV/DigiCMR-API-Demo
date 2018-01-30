// <copyright file="Tracing.Designer.cs" company="Gevaert Consulting BVBA">
//     (c) 2010 DigiCMR
// </copyright>

namespace DigiCMR.Framework
{
    using System.Diagnostics;

    /// <summary>
    /// Provides methods to write diagnostic messages to the DigiCMR.Web <see cref="TraceSource"/>.
    /// </summary>
    public static partial class Tracing
    {
        /// <summary>
        /// The TraceSource to write messages to.
        /// </summary>
        public static TraceSource TraceSource = new TraceSource("DigiCMR.Web");

        /// <summary>
        /// Writes a verbose message to the DigiCMR.Web <see cref="TraceSource"/> using the specified message.
        /// </summary>
        /// <param name="message">The verbose message to write.</param>
        [Conditional("TRACE")]
        public static void TraceVerbose(string message)
        {
            TraceEvent(TraceEventType.Verbose, message, null);
        }

        /// <summary>
        /// Writes a verbose message to the DigiCMR.Web <see cref="TraceSource"/> using the specified object array and formatting information.
        /// </summary>
        /// <param name="format">A format string that contains zero or more format items that correspond to objects in the args array.</param>
        /// <param name="args">An array containing zero or more objects to format.</param>
        [Conditional("TRACE")]
        public static void TraceVerbose(string format, params object[] args)
        {
            TraceEvent(TraceEventType.Verbose, format, args);
        }

        /// <summary>
        /// Writes a verbose message to the DigiCMR.Web <see cref="TraceSource"/> using the specified object array and formatting information if a condition is true.
        /// </summary>
        /// <param name="condition"><c>true</c> to cause a message to be written, <c>false</c> otherwise.</param>
        /// <param name="format">A format string that contains zero or more format items that correspond to objects in the args array.</param>
        /// <param name="args">An array containing zero or more objects to format.</param>
        [Conditional("TRACE")]
        public static void TraceVerboseIf(bool condition, string format, params object[] args)
        {
            if (condition)
            {
                TraceEvent(TraceEventType.Verbose, format, args);
            }
        }

        /// <summary>
        /// Writes an informational message to the DigiCMR.Web <see cref="TraceSource"/> using the specified message.
        /// </summary>
        /// <param name="message">The informative message to write.</param>
        [Conditional("TRACE")]
        public static void TraceInformation(string message)
        {
            TraceEvent(TraceEventType.Information, message, null);
        }

        /// <summary>
        /// Writes an informational message to the DigiCMR.Web <see cref="TraceSource"/> using the specified object array and formatting information.
        /// </summary>
        /// <param name="format">A format string that contains zero or more format items that correspond to objects in the args array.</param>
        /// <param name="args">An array containing zero or more objects to format.</param>
        [Conditional("TRACE")]
        public static void TraceInformation(string format, params object[] args)
        {
            TraceEvent(TraceEventType.Information, format, args);
        }

        /// <summary>
        /// Writes an informational message to the DigiCMR.Web <see cref="TraceSource"/> using the specified object array and formatting information if a condition is true.
        /// </summary>
        /// <param name="condition"><c>true</c> to cause a message to be written, <c>false</c> otherwise.</param>
        /// <param name="format">A format string that contains zero or more format items that correspond to objects in the args array.</param>
        /// <param name="args">An array containing zero or more objects to format.</param>
        [Conditional("TRACE")]
        public static void TraceInformationIf(bool condition, string format, params object[] args)
        {
            if (condition)
            {
                TraceEvent(TraceEventType.Information, format, args);
            }
        }

        /// <summary>
        /// Writes a warning message to the DigiCMR.Web <see cref="TraceSource"/> using the specified message.
        /// </summary>
        /// <param name="message">The warning message to write.</param>
        [Conditional("TRACE")]
        public static void TraceWarning(string message)
        {
            TraceEvent(TraceEventType.Warning, message, null);
        }

        /// <summary>
        /// Writes a warning message to the DigiCMR.Web <see cref="TraceSource"/> using the specified object array and formatting information.
        /// </summary>
        /// <param name="format">A format string that contains zero or more format items that correspond to objects in the args array.</param>
        /// <param name="args">An array containing zero or more objects to format.</param>
        [Conditional("TRACE")]
        public static void TraceWarning(string format, params object[] args)
        {
            TraceEvent(TraceEventType.Warning, format, args);
        }

        /// <summary>
        /// Writes a warning message to the DigiCMR.Web <see cref="TraceSource"/> using the specified object array and formatting information if a condition is true.
        /// </summary>
        /// <param name="condition"><c>true</c> to cause a message to be written, <c>false</c> otherwise.</param>
        /// <param name="format">A format string that contains zero or more format items that correspond to objects in the args array.</param>
        /// <param name="args">An array containing zero or more objects to format.</param>
        [Conditional("TRACE")]
        public static void TraceWarningIf(bool condition, string format, params object[] args)
        {
            if (condition)
            {
                TraceEvent(TraceEventType.Warning, format, args);
            }
        }

        /// <summary>
        /// Writes a trace event to the DigiCMR.Web <see cref="TraceSource"/> using the specified event type and argument array and format.
        /// </summary>
        /// <param name="eventType">One of the <see cref="T:System.Diagnostics.TraceEventType"/> values that specifies the event type of the trace data.</param>
        /// <param name="format">A format string that contains zero or more format items, which correspond to objects in the args array.</param>
        /// <param name="args">An object array containing zero or more objects to format.</param>
        public static void TraceEvent(TraceEventType eventType, string format, object[] args)
        {
            TraceSource.TraceEvent(eventType, (int)eventType, format, args);
        }

        /// <summary>
        /// Writes an error message to the DigiCMR.Web <see cref="TraceSource"/> using the specified error id, object array and formatting information.
        /// </summary>
        /// <param name="id">A numeric identifier for the error.</param>
        /// <param name="format">A format string that contains zero or more format items that correspond to objects in the args array.</param>
        /// <param name="args">An array containing zero or more objects to format.</param>
        [Conditional("TRACE")]
        public static void TraceError(int id, string format, params object[] args)
        {
            TraceSource.TraceEvent(TraceEventType.Error, id, format, args);
        }

        /// <summary>
        /// Writes a critical message to the DigiCMR.Web <see cref="TraceSource"/> using the specified error id, object array and formatting information.
        /// </summary>
        /// <param name="id">A numeric identifier for the critical error.</param>
        /// <param name="format">A format string that contains zero or more format items that correspond to objects in the args array.</param>
        /// <param name="args">An array containing zero or more objects to format.</param>
        [Conditional("TRACE")]
        public static void TraceCriticalError(int id, string format, params object[] args)
        {
            TraceSource.TraceEvent(TraceEventType.Critical, id, format, args);
        }
    }
}
