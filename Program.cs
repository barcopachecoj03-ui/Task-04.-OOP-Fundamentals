using BankApp.Classes;
//var account = new BankAccount("John Doe", 5000); // Create a new BankAccount instance with initial values
var account = new BankAccount(); // Create a new BankAccount instance using the default constructor
try
{
   account.FullName = "Juan"; // Attempt to set an invalid full name
   account.Balance = 6100; // Attempt to set a negative balance
   account.AccountNumber = "123456789"; // Set the account number
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Validation error: {ex.Message}");
}

Console.WriteLine($"Account Holder: {account.FullName}");
Console.WriteLine($"Account Number: {account.AccountNumber}");
account.Balance = 1000; // Set a valid balance
Console.WriteLine($"Account Balance: {account.Balance}");