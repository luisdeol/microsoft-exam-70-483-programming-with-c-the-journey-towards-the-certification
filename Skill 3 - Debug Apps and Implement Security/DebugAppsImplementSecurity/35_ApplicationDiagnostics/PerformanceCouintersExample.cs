using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_ApplicationDiagnostics
{
    public static class PerformanceCouintersExample
    {
        public static void GetExample()
        {
            Console.WriteLine("Press ENTER to stop.");

            using (var performanceCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total"))
            {
                var text = "Processor Time: ";

                Console.WriteLine("Processor Time: ");

                do
                {
                    while (!Console.KeyAvailable)
                    {
                        Console.WriteLine(performanceCounter.NextValue());
                        Console.SetCursorPosition(text.Length, Console.CursorTop);
                    }
                } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
            }

        }
    }
}
