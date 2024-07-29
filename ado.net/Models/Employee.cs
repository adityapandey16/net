using System.ComponentModel.DataAnnotations;

namespace ExamB12.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        public string? Address { get; set; }
    }
}
