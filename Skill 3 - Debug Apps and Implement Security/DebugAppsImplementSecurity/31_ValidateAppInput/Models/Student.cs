using System.ComponentModel.DataAnnotations;

namespace _31_ValidateAppInput.Models
{
    public class Student
    {
        public Student()
        {

        }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Student name must have at least 3 and at most 100 characters.")]
        [Required(ErrorMessage = "The 'Name'property is required. ")]
        public string Name { get; set; }
        [Range(18, 200, ErrorMessage = "Student must be an adult.")]
        public int Age { get; set; }
    }
}
