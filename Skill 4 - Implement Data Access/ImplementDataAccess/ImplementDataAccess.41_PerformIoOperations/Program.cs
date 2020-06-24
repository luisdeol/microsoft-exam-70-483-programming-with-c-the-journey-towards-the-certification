using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ImplementDataAccess._41_PerformIoOperations
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await AsyncHttpCall.GetExample();

            Console.Read();
        }
    }
}
