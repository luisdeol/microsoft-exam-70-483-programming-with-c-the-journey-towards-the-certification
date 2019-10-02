using System;
using System.Globalization;

namespace _27_ManipulateStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            double price = 14.99;
            var now = DateTime.Now;

            var formattedDollarPrice = price.ToString("C", new CultureInfo("en-US", false));
            var formattedCurrentCulturePrice = price.ToString("C", CultureInfo.CurrentCulture);

            Console.WriteLine($"Price (in dollars): {formattedDollarPrice}");
            Console.WriteLine($"Price (in local currency): {formattedCurrentCulturePrice}");

            Console.WriteLine("Date format:");

            var formatteLongdDate = now.ToString("D"); // equivalent to now.ToLongDateString();
            var formattedShortDate = now.ToString("d"); // equivalent to now.ToShortDateString();
            var customFormatDate = now.ToString("dd-MM-yyyy");

            Console.WriteLine("-----Using string.Format-----");
            var stringFormatDate = string.Format("Long date: {0:D}, Shortdate: {1:d}, Currency: {2:C}\n", now, now, price);
            Console.WriteLine(stringFormatDate);

            Console.WriteLine("-----Using ToString overloads-----");

            Console.WriteLine($"Date in LongDate format: {formatteLongdDate}");
            Console.WriteLine($"Date in ShortDate format: {formattedShortDate}");
            Console.WriteLine($"Date in dd-MM-yyyy format: {customFormatDate}\n");

            Console.WriteLine("-----Using string interpolation-----");

            Console.WriteLine($"Long date: {now:D}, Shortdate: {now:d}, Currency: {price:C}");

            Console.ReadKey();
        }
    }
}
