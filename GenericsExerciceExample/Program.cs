using GenericsExerciceExample.Generics;
using GenericsExerciceExample.Models;
var person = new Person
{
    Name = "Lucas",
    Age = 22
};

var number = new BaseGenerics<int>(25);
Console.WriteLine(number.GetItem());

var name = new BaseGenerics<string>("Lucas");
Console.WriteLine(name.GetItem());

var newPerson = new BaseGenerics<Person>(person);
Console.WriteLine(newPerson.GetItem().Name);

var method = ClassGenerics<Person>.GetMethodByName("GetAge");
var age = method?.Invoke(person, null);
Console.WriteLine(age);