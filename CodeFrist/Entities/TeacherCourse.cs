using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFrist.Entities
{
    public class TeacherCourse
    {
        public int Id { get; set; }
        public int TeachersId { get; set; }

        public int CourseId { get; set; }
        public Teacher Teacher { get; set; }
        
        public Course Course {get; set; } 
        
    }
}