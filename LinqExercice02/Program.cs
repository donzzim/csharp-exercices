using System.Globalization;
using LinqExercice02.Entities;

Console.WriteLine("Enter full file path: ");
string path = Console.ReadLine();

List<Employee> list = new List<Employee>();
try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] fields = sr.ReadLine().Split(",");
            string name = fields[0];
            string email = fields[1];
            double salary = double.Parse(fields[2]);

            list.Add(new Employee(name, email, salary));
        }
    }

    Console.Write("Enter salary: ");
    double salaryInput = double.Parse(Console.ReadLine());

    var result01 = list.Where(e => e.Salary > salaryInput).OrderBy(e=> e.Email).Select(e=> e.Email);
    foreach (var e in result01)
    {
        Console.WriteLine(e);
    }
    // SELECT email FROM employees WHERE salary > salaryInput ORDER BY email ASC

    var result02 = list.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);

    Console.Write("Sum of salary of people whose name starts with 'M':" + result02.ToString("F2", CultureInfo.InvariantCulture));
}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}
