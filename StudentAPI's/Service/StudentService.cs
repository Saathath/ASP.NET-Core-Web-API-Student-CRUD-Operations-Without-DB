namespace StudentAPI_s.Service
{

    using Models;
    public class StudentService
    {
        public static List<Student> Students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", Age = 20, Department = "Computer Science" },
            new Student { Id = 2, Name = "Bob", Age = 22, Department = "Mathematics" },
            new Student { Id = 3, Name = "Charlie", Age = 21, Department = "Physics" }
        };  
    }
}
