using System.Security.Cryptography;

namespace CollegeApp.Models
{
    public static  class CollegeRepository
    {
        public static List<Student> Students { get; set; } = new List<Student>()
        {
            new Student()
            {
                Id =1,
                Name = "Deo",
                Email = "Student1@gmail.com",
                Address = "Hyd India"
            },
            new Student() {
                Id =21,
                Name = "Deno",
                Email = "Student2@gmail.com",
                Address = "Koc India"
            }
        };
        

        
    }
}
