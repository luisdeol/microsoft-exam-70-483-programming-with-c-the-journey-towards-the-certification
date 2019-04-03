using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndImplClassHierar
{
    class InheritSealedAbstract
    {
        //static void Main(string[] args)
        //{
        //    var person = new Person("Elrond"); // This code line does not compile, due to the restriction on instantiating an abstract class
        //    var student = new Student("Luis", "Hogwarts");
        //    var employee = new Employee("Felipe", "Two Towers");

        //    person.SayHi();
        //    student.SayHi();
        //    employee.SayHi();

        //    Console.ReadKey();
        //}
    }
    //public abstract class Person
    //{
    //    public Person(string name)
    //    {
    //        Name = name;

    //    }
    //    public string Name { get; set; }
    //    public virtual void SayHi()
    //    {
    //        Console.WriteLine($"Hi! I am {Name}!");
    //    }
    //}

    //public sealed class Student : Person
    //{
    //    public Student(string name, string school) : base(name)
    //    {
    //        SchoolName = school;
    //    }

    //    public string SchoolName { get; set; }

    //    public override void SayHi()
    //    {
    //        Console.WriteLine($"Hi! I am {Name} and I study at {SchoolName}!");
    //    }
    //}

    //public sealed class Employee : Person
    //{
    //    public Employee(string name, string company) : base(name)
    //    {
    //        CompanyName = company;
    //    }
    //    public string CompanyName { get; set; }

    //    public override void SayHi()
    //    {
    //        Console.WriteLine($"Hi! I am {Name} and I work at {CompanyName}!");
    //    }
    //}

    //// The following code does not compile, due to the restriction on inheritance of the sealed keyword on Student class.
    //public class MasterDegreeStudent : Student 
    //{

    //}
}
