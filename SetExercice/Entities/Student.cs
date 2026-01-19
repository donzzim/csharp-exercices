namespace SetExercice.Entities;

public class Student : User, IComparable<Student>
{
    public HashSet<Course> Courses { get; set; } = new();

    public Student(int id, string name) : base(id, name)
    {

    }

    public void EnrollIn(Course course)
    {
        if (Courses.Add(course))
        {
            course.Students.Add(this);
        }
    }

    public void WithdrawFrom(Course course)
    {
        Courses.Remove(course);
        course.Students.Remove(this);
    }

    public int CompareTo(Student? other)
        => other is null ? 1 : Id.CompareTo(other.Id);

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if(!(obj is Student)) return false;

        Student u  = (Student)obj;
        return Id.Equals(u.Id);
    }
}
