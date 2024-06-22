using System;
using System.Diagnostics;

namespace MyClassLibrary
{
    /// <summary>
    /// To log on windows event log
    /// </summary>
    public class clsLogging
    {
        #region Class init
        public string SourceName { get; set; }
        public clsLogging(string sourceName)
        {
            SourceName = sourceName;
        }
        #endregion

        #region Event Performance
        /// <summary>
        /// an event on source created
        /// </summary>
        public event EventHandler<string> SourceCreated;
        #endregion

        /// <summary>
        /// This method help you to write on event log
        /// </summary>
        /// <param name="Message"> the message that you want to write</param>
        /// <param name="EventType">event type (Information, Error, Warning)</param>
        public void Write(string Message, EventLogEntryType EventType)
        {
            if (!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName, "Application");

                SourceCreated?.Invoke(this, SourceName);
            }

            EventLog.WriteEntry(SourceName, Message, EventType);

        }
    }
}
