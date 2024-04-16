using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Courses.Models
{
    public class Video
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = "";
        [Required]
        public string Url { get; set; } = "";
        [Required]
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; } 
    }
}
