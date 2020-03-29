using _31_ValidateAppInput.Models;
using System;

namespace _31_ValidateAppInput
{
    public static class ManageDataIntegrity
    {
        public static void GetExample()
        {
            var student = new Student("l", 5);

            var entityErrors = Validator<Student>.Validate(student);

            Console.WriteLine($"Errors: {string.Join(", ", entityErrors)}");

            Console.ReadLine();
        }
    }
}
