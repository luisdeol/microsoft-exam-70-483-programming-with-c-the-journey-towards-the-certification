using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndImplClassHierar
{
    class ImplIComparable
    {
        //static void Main(string[] args)
        //{
        //    var student1 = new Student("Luis", "Hogwarts", 98);
        //    var student2 = new Student("Felipe", "Azkaban", 13);
        //    var student3 = new Student("Gandalf", "Middle-Earth", 25);

        //    var students = new List<Student>
        //    {
        //        student1,
        //        student2,
        //        student3
        //    };

        //    students.Sort();

        //    Console.WriteLine("Ordered students by grade.");

        //    students.ForEach(s => Console.WriteLine(s.Name));

        //    Console.ReadKey();
        //}
    }

    //public class Student : IComparable
    //{
    //    public Student(string name, string school, int score) 
    //    {
    //        Name = name;
    //        SchoolName = school;
    //        Score = score;
    //    }

    //    public string Name { get; set; }
    //    public string SchoolName { get; set; }
    //    public int Score { get; set; }

    //    public int CompareTo(object obj)
    //    {
    //        if (obj == null)
    //        {
    //            return 1;
    //        }

    //        var comparedStudent = obj as Student;

    //        if (comparedStudent == null)
    //        {
    //            throw new ArgumentException("Object is not a Student!");
    //        }

    //        // Students will be ordered by Score.
    //        return Score.CompareTo(comparedStudent.Score);
    //    }
    //}
}
