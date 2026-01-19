namespace SetExercice.Entities;

public abstract class User
{
    public int Id { get; set; }
    public string Name { get; set; }

    protected User(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
