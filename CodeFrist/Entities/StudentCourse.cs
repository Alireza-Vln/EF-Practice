﻿namespace CodeFrist.Entities
{
    public class StudentCourse
    {
        public int Id { get; set; }
        public int StudentsId { get; set; }
        public int CourseId { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}