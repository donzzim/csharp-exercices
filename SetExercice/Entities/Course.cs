namespace SetExercice.Entities;

public class Course
{
    public string Name { get; set; }
    public Instructor Instructor { get; set; }
    public SortedSet<Student> Students { get; set; } = new();

    public Course(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return $"Course Data: \n Name: {Name} \n Teacher: {Instructor.Name}";
    }
}
