namespace GenericsExerciceExample.Models;

public class Person
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    
    public bool GetAge() => Age >= 18;
}