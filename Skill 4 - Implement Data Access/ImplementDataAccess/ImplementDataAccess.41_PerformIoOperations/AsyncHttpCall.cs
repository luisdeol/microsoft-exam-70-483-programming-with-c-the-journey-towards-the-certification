using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ImplementDataAccess._41_PerformIoOperations
{
    public static class AsyncHttpCall
    {
        public static async Task GetExample()
        {
            var jsonPlaceholderResult = await CallJsonPlaceholderApi();

            Console.WriteLine($"API Response: {jsonPlaceholderResult}");

        }

        private static async Task<string> CallJsonPlaceholderApi()
        {
            var jsonPlaceHolderUrl = "https://jsonplaceholder.typicode.com/todos";

            var httpClient = new HttpClient();

            var httpResponseMessage = await httpClient.GetAsync(jsonPlaceHolderUrl);

            var messageContent = await httpResponseMessage.Content.ReadAsStringAsync();

            return messageContent;
        }
    }

    
}
