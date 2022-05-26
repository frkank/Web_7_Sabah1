using System.Collections.Generic;

namespace DersAtamaApp.Models.Entity
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Teacher { get; set; }
        public sbyte Credit { get; set; }
        public sbyte Period { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
    }
}
