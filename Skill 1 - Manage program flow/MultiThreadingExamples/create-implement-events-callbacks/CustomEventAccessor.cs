using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_implement_events_callbacks
{
    class CustomEventAccessor
    {
        //public class MyArgs : EventArgs
        //{
        //    public MyArgs(int value)
        //    {
        //        Value = value;
        //    }
        //    public int Value { get; set; }
        //}
        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        var pub = new Pub();

        //        pub.OnChange += (sender, e) => Console.WriteLine($"Event raised: {e.Value}");
        //        pub.OnChange += (sender, e) => Console.WriteLine($"Event raised: {e.Value}");

        //        pub.Raise();
        //        Console.ReadKey();
        //    }
        //}

        //public class Pub
        //{
        //    private event EventHandler<MyArgs> onChange = delegate { };
        //    public event EventHandler<MyArgs> OnChange
        //    {
        //        add
        //        {
        //            lock (onChange)
        //            {
        //                onChange += value;
        //            }
        //        }
        //        remove
        //        {
        //            lock (onChange)
        //            {
        //                onChange -= value;
        //            }
        //        }
        //    }
        //    public void Raise()
        //    {
        //        onChange(this, new MyArgs(30));
        //    }
        //}
    }
}
