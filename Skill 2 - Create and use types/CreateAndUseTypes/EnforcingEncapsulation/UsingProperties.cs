using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnforcingEncapsulation
{
    class UsingProperties
    {
        //static void Main(string[] args)
        //{
        //    var employee = new Employee("Luis", 10000.8738);

        //    Console.WriteLine(employee.Salary);

        //    employee.Salary = "12003,230";

        //    Console.WriteLine(employee.Salary);

        //    employee.Salary = "-0.234"; // Throws exception because of the custom SET code. 

        //    Console.ReadKey();
        //}
    }

    //public class Person
    //{
    //    public Person(string name)
    //    {
    //        Name = name;
    //    }
    //    private int PersonId { get; set; }
    //    protected string Email { get; set; }
    //    public string Name { get; set; }
    //}

    //public class Employee : Person
    //{
    //    public Employee(string name, double salary) : base(name)
    //    {
    //        _salary = salary;
    //    }

    //    public string CompanyName = "The Company";
    //    private double _salary;
    //    public string Salary
    //    {
    //        get
    //        {
    //            return _salary.ToString("#.##");
    //        }
    //        set
    //        {
    //            var doubleValue = Double.Parse(value);

    //            if (doubleValue < 0)
    //                throw new ArgumentOutOfRangeException("The Salary value should be positive!");
    //            _salary = doubleValue;
    //        }
    //    }
    //    public void ShowEmail()
    //    {
    //        Console.WriteLine(Email);
    //    }
    //}
}
