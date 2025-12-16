using System.ComponentModel.DataAnnotations;
namespace MVC_CRUD.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}