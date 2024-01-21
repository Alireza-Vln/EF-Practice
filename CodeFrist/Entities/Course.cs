using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFrist.Entities
{
    public class Course
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public byte Unit { get; set; }

        public Group Group { get; set; }
        public int GroupId { get; set; }
        public HashSet<TeacherCourse> teacherCourses { get; set; }= new HashSet<TeacherCourse>();

        public HashSet<StudentCourse> studentCourses { get; set; } = new HashSet<StudentCourse>();
    }
}
