using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeTypes
{
    class UserDefinedConversion
    {
        //static void Main(string[] args)
        //{
        //    var employee = new Employee("Luis", "Software Developer", 100000.90m); // Dream on, Luis...

        //    // You are what you earn... literally. lol
        //    decimal salary = employee;
        //    int salaryInt = (int)employee;

        //    Console.WriteLine(salary);
        //    Console.WriteLine(salaryInt);

        //    Console.ReadKey();
        //}
    }

    //public class Person
    //{
    //    public Person(string name)
    //    {
    //        Name = name;
    //    }

    //    public string Name { get; set; }
    //}

    //public class Employee : Person
    //{
    //    public Employee(string name, string role, decimal salary) : base(name)
    //    {
    //        Role = role;
    //        Salary = salary;
    //    }

    //    // The following method allows you to assign implicitly
    //    // Employee to a decimal variable, actually assigning the Salary value as decimal
    //    public static implicit operator decimal(Employee employee)
    //    {
    //        return employee.Salary;
    //    }

    //    // The following method allows you to assign explicitly
    //    // Employee to a int variable, actually assigning the Salary value as int
    //    public static explicit operator int(Employee employee)
    //    {
    //        return (int)employee.Salary;
    //    }

    //    public string Role { get; set; }
    //    public decimal Salary { get; set; }
    //}
}
