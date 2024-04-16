using System.ComponentModel.DataAnnotations;

namespace Courses.Models
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "";
        public ICollection<Semester> Semesters { get; set; }= new HashSet<Semester>();
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
