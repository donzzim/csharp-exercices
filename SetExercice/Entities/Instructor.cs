namespace SetExercice.Entities;

public class Instructor : User
{
    public List<Course> Courses { get; } = new();

    public Instructor(int id, string name) : base(id, name) { }

    public void AddCourse(Course course)
    {
        Courses.Add(course);
        course.Instructor = this;
    }

    public int GetTotalStudents()
    {
        HashSet<Student> totalStudents = new();

        foreach (var course in Courses)
        {
            totalStudents.UnionWith(course.Students);
        }

        return totalStudents.Count;
    }

    public override string ToString()
    {
        return $"{Name} total students: {GetTotalStudents()}";
    }
}
