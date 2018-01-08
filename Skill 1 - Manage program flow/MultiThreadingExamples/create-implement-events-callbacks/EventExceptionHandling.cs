using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_implement_events_callbacks
{
    class EventExceptionHandling
    {
    //    static void Main(string[] args)
    //    {
    //        var pub = new Pub();

    //        pub.OnChange += (sender, e) => Console.WriteLine("Event raised 1");
    //        pub.OnChange += (sender, e) => throw new Exception();
    //        pub.OnChange += (sender, e) => Console.WriteLine("Event raised 3");

    //        try
    //        {
    //            pub.Raise();
    //        }
    //        catch (AggregateException ex)
    //        {
    //            Console.WriteLine(ex.InnerExceptions.Count);   
    //        }
    //        Console.ReadKey();
    //    }      
    //}

    //public class Pub
    //{
    //    public event EventHandler OnChange = delegate { };
       
    //    public void Raise()
    //    {
    //        var exceptions = new List<Exception>();

    //        foreach (var handler in OnChange.GetInvocationList())
    //        {
    //            try
    //            {
    //                handler.DynamicInvoke(this, EventArgs.Empty);
    //            }
    //            catch (Exception e)
    //            {
    //                exceptions.Add(e);
    //            }
    //        }

    //        if (exceptions.Any())
    //            throw new AggregateException(exceptions);
    //    }
    //}
    }
}
