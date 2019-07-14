using System;

namespace _25RuntimeReflection
{
    public class ClassForReflectionPractice
    {
        public ClassForReflectionPractice(string oneString)
        {
            _oneString = oneString;
        }

        private string _oneString { get; set; }
        private int _oneInteger { get; set; }

        public void SayHello()
        {
            Console.WriteLine("Hello, World!");
        }

        private void Whisper(string message)
        {
            Console.WriteLine($"Shhh... hey... {message}");
        }

        //static void Main(string[] args)
        //{
        //    var classForReflectionPractice = new ClassForReflectionPractice("test");

        //    var assembly = Assembly.GetExecutingAssembly(); // Also, it could be Assembly.Load("25RuntimeReflection");

        //    Console.WriteLine($"Assembly FullName: {assembly.FullName}");

        //    var types = assembly.GetTypes().Where(t => t.IsClass).ToList();

        //    types.ForEach(type => PrintTypeInformation(type));

        //    InvokePrivateWhisper(classForReflectionPractice, "Whisper message!");

        //    Console.Read();
        //}

        //static void PrintTypeInformation(Type type)
        //{
        //    Console.WriteLine($"Name: {type.Name}, FullName: {type.FullName}");

        //    Console.WriteLine("-- Properties --");

        //    foreach (var property in type.GetProperties())
        //    {
        //        Console.WriteLine($"Name: {property.Name}");
        //    }
        //}

        //static void InvokePrivateWhisper(ClassForReflectionPractice instance, string message)
        //{
        //    var whisperMethod = instance.GetType().GetMethod("Whisper", BindingFlags.NonPublic | BindingFlags.Instance);

        //    Console.WriteLine("Invoking private method 'Whisper'");

        //    whisperMethod.Invoke(instance, new object[] { message });
        //}
    }
}
