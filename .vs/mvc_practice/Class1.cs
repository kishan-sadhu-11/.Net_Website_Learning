using System.ComponentModel.DataAnnotations;

namespace mvc_practice.Models
{
    public class StudentModel
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public int Password { get; set; }
    }
}
