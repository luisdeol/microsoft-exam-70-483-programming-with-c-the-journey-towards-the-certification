using System.Diagnostics;

namespace _35_ApplicationDiagnostics
{
    public static class WritingToEtw
    {
        public static void GetExample()
        {
            var source = "35_ApplicationDiagnostics";

            using (var eventLog = new EventLog("Aplicativo"))
            {
                if (!EventLog.SourceExists(source))
                {
                    EventLog.CreateEventSource(source, "LogApp");
                }

                eventLog.Source = source;

                eventLog.EnableRaisingEvents = true;
                eventLog.EndInit();

                eventLog.WriteEntry("Just testing EventDe Log writing.", EventLogEntryType.Information);
            }
        }
    }
}
