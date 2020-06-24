using System;
using System.IO;
using System.Net;

namespace ImplementDataAccess._41_PerformIoOperations
{
    public static class NetworkCallUsingWebRequest
    {
        public static void GetExample()
        {
            var jsonPlaceHolderUrl = "https://jsonplaceholder.typicode.com/todos";

            var webRequest = WebRequest.Create(jsonPlaceHolderUrl);

            var webResponse = webRequest.GetResponse();
            var responseStream = webResponse.GetResponseStream();

            var streamReader = new StreamReader(responseStream);

            var responseText = streamReader.ReadToEnd();

            webResponse.Close();

            Console.WriteLine($"API Response: {responseText}");
        }
    }
}
