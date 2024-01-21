using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CodeFrist.Entities
{
    public  class Student
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string   LastName { get; set; }
      
        public Gender Gender { get; set; }
        public Group Group { get; set; }
        public int GroupId { get; set; }

        public HashSet<StudentCourse> Courses { get; set; } = new HashSet<StudentCourse>();

    }
    public enum Gender
    {
        Male=1,
        famale=2, 
    }
}
