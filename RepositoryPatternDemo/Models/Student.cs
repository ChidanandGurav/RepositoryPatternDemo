using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepositoryPatternDemo.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]//pk in col in DB
        public int RollNo { get; set; }
        [Required]

        public string? Name { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        
        public int Percentage { get; set; }
    }
}
