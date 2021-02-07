namespace ContosoUniversity.Models
{
    public class CourseAssignment //The Instructor-to-Courses many-to-many relationship requires a join table, and the entity for that join table is CourseAssignment.
    {
        public int InstructorID { get; set; }
        public int CourseID { get; set; }
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}