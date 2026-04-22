using Strategy.Controller;
using Strategy.Service;

TaxService _taxService = new TaxService();
TaxController _taxController = new TaxController(_taxService);

Console.WriteLine("Enter tax type (ICMS, ISS, IPI):");
string taxType = Console.ReadLine();
Console.WriteLine("Enter tax amount:");
decimal taxAmount = decimal.Parse(Console.ReadLine());

decimal result = _taxController.Calculate(taxType, taxAmount);
Console.WriteLine($"Calculated tax: {result}");