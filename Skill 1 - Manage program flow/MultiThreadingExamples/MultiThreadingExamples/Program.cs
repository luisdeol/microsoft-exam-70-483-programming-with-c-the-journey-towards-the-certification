using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var anIncrediblyBigSet = Enumerable.Range(0, 10);

            var parallelEvenNumbers = anIncrediblyBigSet
                .AsParallel()
                .AsOrdered() // it does not matter if it is ordered. ForAll removes any specified order.
                .Where(number => number % 2 == 0);

            parallelEvenNumbers.ForAll(even => Console.WriteLine($"Number {even}"));

            Console.ReadLine();
        }
    }
}
