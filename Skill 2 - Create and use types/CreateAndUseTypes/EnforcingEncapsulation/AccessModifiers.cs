using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnforcingEncapsulation
{
    public class AccessModifiers
    {
        //static void Main(string[] args)
        //{
        //    var person = new Person();
        //    var employee = new Employee();

        //    // Console.WriteLine(employee.PersonId); Does not compile because PersonId is private, so it is only accessible inside the Person Class
        //    // Console.WriteLine(employee.Email); Does not compile because Email property is only accessible inside the the derived class Employee.
        //    employee.ShowEmail();
        //    Console.WriteLine(person.Name);
        //    Console.WriteLine(employee.CompanyName);
        //}
    }

    //public class Person
    //{
    //    private int PersonId { get; set; }
    //    protected string Email { get; set; }
    //    public string Name { get; set; }
    //}

    //public class Employee : Person
    //{
    //    public string CompanyName = "The Company";

    //    public void ShowEmail()
    //    {
    //        Console.WriteLine(Email);
    //    }
    //}
}
