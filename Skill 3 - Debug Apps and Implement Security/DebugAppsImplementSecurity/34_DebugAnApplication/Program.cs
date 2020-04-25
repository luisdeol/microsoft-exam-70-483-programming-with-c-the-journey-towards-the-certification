#define CUSTOM_DIR
// #undef CUSTOM_DIR 
// undef removes the preprocessor directive definition. Uncomment the code above and notice how the display message changes.

using System;

namespace _34_DebugAnApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 40;
            var anotherNumber = 100;

            #if DEBUG
            Console.WriteLine("Debug mode.");
            #else
	        Console.WriteLine("Release mode.");
#endif

            var sum = number + anotherNumber;

            #if CUSTOM_DIR
            Console.WriteLine("CUSTOM_DIR defined");
            #else
            Console.WriteLine("CUSTOM_DIR NOT DEFINED");
            #endif

            #region REGION 1
            Console.WriteLine("Region 1");
            #endregion

            Console.ReadLine();
        }
    }
}
