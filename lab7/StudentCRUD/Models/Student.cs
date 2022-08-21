using System.ComponentModel.DataAnnotations;

namespace StudentCRUD.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public int semester { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
