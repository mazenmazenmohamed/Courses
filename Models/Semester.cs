using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Courses.Models
{
    public class Semester
    {
        [Key]
        public int Id { get; set;}
        [Required]
        public string Name { get; set; } = "";
        [Required]
        [ForeignKey("Grade")]
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
