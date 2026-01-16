using System.Reflection;

namespace GenericsExerciceExample.Generics;

public class ClassGenerics<T> where T:class
{
    public static MethodInfo? GetMethodByName(string name)
    => typeof(T)
        .GetMethods()
        .FirstOrDefault(m =>
            m.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));
}