using System;
using System.Diagnostics;
using System.Text;

namespace _35_ApplicationDiagnostics
{
    public static class StopwatchExample
    {
        public static void GetExample()
        {
            var stopWatch = new Stopwatch();

            Console.WriteLine("Prepare...");

            stopWatch.Start();

            Console.WriteLine($"Stopwatch just started! Elapsed Time: {stopWatch.Elapsed:mm\\:ss\\.ff}");

            var string1 = ConcatenateStringUsingStringBuilder();

            stopWatch.Stop();

            Console.WriteLine($"First stop: Elapsed time for ConcatenateString is {stopWatch.ElapsedMilliseconds}");

            stopWatch.Reset();

            stopWatch.Start();

            var string2 = ConcatenateString();

            stopWatch.Stop();

            Console.WriteLine($"First stop: Elapsed time for ConcatenateString is {stopWatch.ElapsedMilliseconds}");

        }

        public static string ConcatenateString()
        {
            var word = string.Empty;

            for (var i = 0; i < 100000; i++)
            {
                word += "a";
            }

            return word;
        }

        public static string ConcatenateStringUsingStringBuilder()
        {
            var word = new StringBuilder();

            for (var i = 0; i < 100000; i++)
            {
                word.Append("a");
            }

            return word.ToString();
        }
    }
}
