using System;

namespace _25RuntimeReflection
{
    class MyCoolAttribute : Attribute
    {
        public string Phrase { get; set; }
        public MyCoolAttribute(string phrase)
        {
            Phrase = phrase;
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Checking if the Phrase property was set when using the custom attribute on UsingAttribute class.
    //        var attribute = (MyCoolAttribute)Attribute.GetCustomAttribute(typeof(UsingAttribute), typeof(MyCoolAttribute));

    //        Console.WriteLine(attribute.Phrase);

    //        Console.Read();
    //    }
    //}

    //[MyCool("Let's clear that certification!")]
    //class UsingAttribute
    //{

    //}
}
