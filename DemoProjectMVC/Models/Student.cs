using System.ComponentModel.DataAnnotations;

namespace DemoProjectMVC.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Full Name")]
        public string Name { get; set; }=string.Empty;
        [Required]
        [MaxLength(100)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string Email { get; set; } = string.Empty;
        [Required]
        [MaxLength(15)]
        public string Phone { get; set; } = string.Empty;
    }
}
