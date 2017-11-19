using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manage_multithreading
{
    class UsingInterlockerClass
    {
        //static void Main(string[] args)
        //{
        //    int theAlmightyZero = 0;
        //    object _lockTheSavior = new object();

        //    Task newAmazingTask = Task.Run(() =>
        //    {
        //        for (int i = 0; i < 1000000; i++)
        //            Interlocked.Increment(ref theAlmightyZero);
        //    });

        //    for (int j = 0; j < 1000000; j++)
        //        Interlocked.Decrement(ref theAlmightyZero);

        //    newAmazingTask.Wait();

        //    Console.WriteLine("Here it comes a ZERO value (that is STILL true)! " + theAlmightyZero);
        //    Console.ReadLine();
        //}
    }
}
