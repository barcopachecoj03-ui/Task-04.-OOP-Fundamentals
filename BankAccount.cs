using System.Collections.Specialized;

namespace BankApp.Classes;

public class BankAccount
{
    private string fullName;
    private decimal balance;

    public string FullName
    {
        get
        {
            return fullName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Full name cannot be empty or whitespace.", nameof(value));
            }
            fullName = value;
        }
    }

    public decimal Balance
    {
        get => balance;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Balance cannot be negative.", nameof(value));
            }
            balance = value;
        }
    }
    public string AccountNumber { get; set; }//auto-implemented property for AccountNumber
    public bool HasPositiveBalance => Balance > 0; // Read-only property to check if the balance is positive
    public BankAccount( string fn,decimal b)
    {
        FullName = fn;
        Balance = b;
    }
    //Constructor Overloading + constructor chaining
    public BankAccount():this("unknown",0)
    {
        AccountNumber = "000000000";
    }
    public void Deposit(decimal amount)
    {
        // Validate the deposit amount
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive.", nameof(amount));
        }
        // Update the balance
        Balance += amount;
    }
    public void Withdraw(decimal amount)
    {
        // Validate the withdrawal amount
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive.", nameof(amount));
        }
        if (amount > Balance)
        {
            throw new InvalidOperationException("Insufficient funds for this withdrawal.");
        }
        // Update the balance
        Balance -= amount;
    }
}
