using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_implement_events_callbacks
{
    class EventWithEventHandler
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
        //    public event EventHandler<MyArgs> OnChange = delegate { };

        //    public void Raise()
        //    {
        //        OnChange(this, new MyArgs(30));
        //    }
        //}
    }
}
