using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace ImplementDataAccess._41_PerformIoOperations
{
    public static class WorkingWithStreams
    {
        public static void GetExample()
        {
            var filePathUncompressed = @"../../FileToCompress/file.txt";
            var filePathCompressed = @"../../FileToCompress/file.gz";

            Console.WriteLine("Type a text content for the new file.");

            var content = Console.ReadLine();
            var contentBytes = Encoding.ASCII.GetBytes(content);

            content = string.Concat(Enumerable.Repeat(content, 1000));

            using (var streamWriter = File.CreateText(filePathUncompressed))
            {
                streamWriter.Write(content);

                using (var compressedFileStream = File.Create(filePathCompressed))
                {
                    using (var gzipStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        gzipStream.Write(contentBytes, 0, contentBytes.Length);
                    }
                }
            }

            var uncompressedFileInfo = new FileInfo(filePathUncompressed);
            var compressedFileInfo = new FileInfo(filePathCompressed);

            Console.WriteLine($"Uncompressed file: {uncompressedFileInfo.Length}");
            Console.WriteLine($"Compressed file: {compressedFileInfo.Length}");
        }
    }
}
