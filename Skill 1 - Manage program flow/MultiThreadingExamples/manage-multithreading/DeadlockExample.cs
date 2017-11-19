using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manage_multithreading
{
    class DeadlockExample
    {
        //static void Main(string[] args)
        //{
        //    object _lockSaviorOne = new object();
        //    object _lockSaviorTwo = new object();

        //    Task leTask = Task.Run(() =>
        //    {
        //        lock (_lockSaviorOne)
        //        {
        //            Thread.Sleep(1000);
        //            lock (_lockSaviorTwo)
        //                Console.WriteLine("Hey, One and Two are already locked!");
        //        }
        //    });

        //    Task leSecondTask = Task.Run(() =>
        //    {
        //        lock (_lockSaviorTwo)
        //        lock (_lockSaviorOne)
        //            Console.WriteLine("Yeah, One and Two are locked!");

        //    });

        //    Task.WaitAll(leTask, leSecondTask);

        //    Console.ReadLine();
        //}
    }
}
