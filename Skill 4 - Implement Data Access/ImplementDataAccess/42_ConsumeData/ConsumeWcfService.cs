using System;

namespace _42_ConsumeData
{
    public static class ConsumeWcfService
    {
        public static void GetExample()
        {
            var serviceReferenceClient = new ServiceReference1.ServiceClient();

            var result = serviceReferenceClient.GetData(100);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
