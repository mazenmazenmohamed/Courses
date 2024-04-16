using Microsoft.EntityFrameworkCore;

namespace Courses.Models
{
    public class CoursesDb : DbContext
    {
        internal readonly object Semester;

        public CoursesDb(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Grade> TblGrade { get; set; }
        public DbSet<Semester> TblSemester { get; set; }
        public DbSet<Course> TblCourse { get; set; }
        public DbSet<Video> TblVideo { get; set; }
    }
}
