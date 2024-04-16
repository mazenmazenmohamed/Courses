using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Courses.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = "";
        [Required]
        [ForeignKey("Grade")]
        public int GradeId { get; set; }
        [Required]
        [ForeignKey("Semester")]
        public int SemesterId { get; set; }
        public Grade Grade { get; set; } 
        public Semester Semester { get; set; }
        public ICollection<Video> Videos { get; set; } = new HashSet<Video>();

    }
}
