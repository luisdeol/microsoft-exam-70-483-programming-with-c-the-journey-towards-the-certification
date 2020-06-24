using System;
using System.IO;

namespace ImplementDataAccess._41_PerformIoOperations
{
    public static class WriteReadFile
    {
        public static void GetExample()
        {
            var myNewFile = @"../../Directory/file_6.txt";

            Console.WriteLine("Type a text content for the new file.");

            var content = Console.ReadLine();

            using (var streamWriter = File.CreateText(myNewFile))
            {
                streamWriter.Write(content);
            }

            using (var streamReader = File.OpenText(myNewFile))
            {
                var fileContent = streamReader.ReadToEnd();

                Console.WriteLine($"File content: {fileContent}");
            }
        }
    }
}
