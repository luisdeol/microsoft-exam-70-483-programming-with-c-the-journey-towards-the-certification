using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manage_multithreading
{
    class TheVolatileKeyword
    {
        private static int _theFlag;
        private static volatile int _theValue;
        public static void TheFirstThread()
        {
            _theValue = 10;
            _theFlag = 1;
        }

        public static void TheSecondThread()
        {
            if (_theFlag == 1)
                Console.WriteLine(_theValue);
        }
    }
}
