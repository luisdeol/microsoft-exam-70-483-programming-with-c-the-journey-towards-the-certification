using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingExamples
{
    class UsingWaitAllOnMultipleTasks
    {
        //static void Main(string[] args)
        //{
        //    Stopwatch myStopWatch = new Stopwatch();

        //    Task[] aSetOfTasks = new Task[3];

        //    myStopWatch.Start();
        //    aSetOfTasks[0] = Task.Run(() =>
        //    {
        //        Thread.Sleep(1000);
        //        Console.WriteLine("Luis drinks coffee.");
        //    });

        //    aSetOfTasks[1] = Task.Run(() =>
        //    {
        //        Thread.Sleep(1000);
        //        Console.WriteLine("Luis fixes some bugs.");
        //    });

        //    aSetOfTasks[2] = Task.Run(() =>
        //    {
        //        Thread.Sleep(1000);
        //        Console.WriteLine("Luis... falls asleep.");
        //    });

        //    Task.WaitAll(aSetOfTasks);

        //    myStopWatch.Stop();
        //    var timeStampStopWatch = myStopWatch.Elapsed;
        //    Console.WriteLine($"It took {timeStampStopWatch.ToString("g")}");

        //    Console.ReadLine();
        //}
    }
}
