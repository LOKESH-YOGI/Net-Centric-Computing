using System.Collections.Generic;
using System.Linq;
namespace Lambda_Expression
{
    class Student
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prepared by: Lokesh Nath Yogi\n");
            List<Student> students = new List<Student>()
            {
                new Student {Id = 1, DepartmentId = 101, Name = "Apple", Address = "Kirtipur"}, 
                new Student {Id = 2, DepartmentId = 102, Name = "Banana", Address = "Lalitpur"}, 
                new Student {Id = 3, DepartmentId = 101, Name = "Cherry", Address = "Lainchaur"}, 
                new Student {Id = 4, DepartmentId = 103, Name = "Mango", Address = "Balaju"}, 
                new Student {Id = 5, DepartmentId = 102, Name = "Grapes", Address = "Kalimati"}
            };
            Console.Write("Enter Department ID to search students:");
            int depId = Convert.ToInt32(Console.ReadLine());
            var filteredStudents = students.Where(s => s.DepartmentId == depId).ToList();
            Console.WriteLine($"\nStudents in Department {depId}:");
            if (filteredStudents.Count > 0)
            {
                foreach (var student in filteredStudents)
                {
                    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Address: {student.Address}");
                }
            }
            else
            {
                Console.WriteLine("No students found in this department.");
            }
        }
    }
}
