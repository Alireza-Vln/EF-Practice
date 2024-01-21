namespace CodeFrist.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public HashSet<Teacher> Teachers { get; set; }=new HashSet<Teacher>();
        public HashSet<Student> Students { get; set; } = new HashSet<Student>();
        public HashSet<Course> Courses { get; set; } = new HashSet<Course>();
        

    }
}