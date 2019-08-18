using System;

namespace _26_ManageObjLifecycle
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseClassWithFinalizer = new BaseClassWithFinalizer();
            baseClassWithFinalizer = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.ReadKey();
        }
    }
}
