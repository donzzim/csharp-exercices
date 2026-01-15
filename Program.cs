using System;
using System.Collections.Generic;
using System.Linq;
using InterfaceExercice.Entities;
using InterfaceExercice.Services;

Console.WriteLine("Enter contract data");

Console.Write("Number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Date (DD/MM/YYYY): ");
DateTime date = DateTime.Parse(Console.ReadLine());

Console.Write("Contract value: ");
double value = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter number of installments: ");
int numInstallments = Convert.ToInt32(Console.ReadLine());

Contract contract = new Contract(number, date, value);

ContractService contractService = new ContractService(new PaypalService());
contractService.ProcessContract(contract, numInstallments);

Console.WriteLine("Installments:");
foreach (Installment installment in contract.Installments)
{
    Console.WriteLine($"{installment.DueDate} - {installment.Amount}");
}