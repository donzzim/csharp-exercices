namespace SetExercice.Entities;

public class Instructor : User
{
    public List<Course> Courses { get; set; } = new();

    public Instructor(int id, string name) : base(id, name)
    {
        Id = id;
        Name = name;
    }

    public void AddCourse(Course course)
    {
        Courses.Add(course);
        course.Instructor = this;
    }
}
