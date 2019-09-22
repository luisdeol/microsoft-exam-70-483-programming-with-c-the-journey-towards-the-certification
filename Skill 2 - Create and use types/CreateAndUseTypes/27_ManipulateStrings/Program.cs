using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;

namespace _27_ManipulateStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = new StringBuilder();

            for (var i = 0; i <= 100; i++)
            {
                numbers.AppendLine(i.ToString());
            }

            Console.WriteLine(numbers);

            var sbPersonJson = new StringBuilder();
            var stringWriter = new StringWriter(sbPersonJson);

            using (var jsonWriter = new JsonTextWriter(stringWriter))
            {
                jsonWriter.WriteStartObject();

                jsonWriter.WritePropertyName("Name");
                jsonWriter.WriteValue("Luis");

                jsonWriter.WritePropertyName("University");
                jsonWriter.WriteValue("IFRN");

                jsonWriter.WriteEndObject();
            }

            Console.WriteLine($"Output using JsonTextWriter: {sbPersonJson}");

            using (var stringReader = new StringReader(sbPersonJson.ToString()))
            {
                var content = stringReader.ReadToEnd();

                Console.WriteLine($"Output using StringReader: {content}");
            }

            Console.ReadKey();
        }
    }
}
