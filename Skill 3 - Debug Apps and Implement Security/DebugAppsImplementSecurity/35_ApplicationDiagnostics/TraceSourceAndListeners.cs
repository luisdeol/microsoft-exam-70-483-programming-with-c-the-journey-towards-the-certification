using System.Diagnostics;
using System.IO;

namespace _35_ApplicationDiagnostics
{
    public static class TraceSourceAndListeners
    {
        public static void GetExample()
        {
            var fileStream = File.Create("log.text");

            var textFileListener = new TextWriterTraceListener(fileStream);

            var traceSource = new TraceSource("MyAppTraceSource", SourceLevels.All);
            traceSource.Listeners.Clear();
            traceSource.Listeners.Add(textFileListener);

            traceSource.TraceInformation("Starting application");

            traceSource.TraceEvent(TraceEventType.Error, 0, "An error ocurred");

            traceSource.TraceData(TraceEventType.Critical, 1, new { Text = "Error" });

            traceSource.Flush();
            traceSource.Close();
        }
    }
}
