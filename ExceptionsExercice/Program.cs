using ExceptionsExercicio.Entities;
using ExceptionsExercicio.Entities.Exceptions;
using System.Globalization;


Console.WriteLine("Enter account data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Holder: ");
string holder = Console.ReadLine();

Console.Write("Initial balance: ");
double balance = double.Parse(Console.ReadLine());

Console.Write("Withdraw limit: ");
double limit = double.Parse(Console.ReadLine());

Account acc1 = new Account(number, holder, balance, limit);

Console.WriteLine();

Console.Write("Enter amount for withdraw: ");
double amount  = double.Parse(Console.ReadLine());

try
{
    acc1.Withdraw(amount);
    Console.Write("New balance: " + acc1.Balance.ToString("F2", CultureInfo.InvariantCulture));

}
catch(WithdrawError e) 
{  
    Console.WriteLine("Withdraw error: " + e.Message); 
}