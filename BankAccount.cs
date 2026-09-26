public class BankAccount
{
public string Owner { get; set; } = "";
    private double balance;

    // Deposit adds money to the account.
    public void Deposit(double amount)
    {
        balance += amount;
    }

    // Withdraw removes money from the account.
    public void Withdraw(double amount)
    {
        balance -= amount;
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Balance: {balance}");
    }
}

// SavingsAccount inherits from BankAccount.
public class SavingsAccount : BankAccount
{
    // This method belongs to SavingsAccount.
    public void ShowSavingsAccount()
    {
        Console.WriteLine("This is a savings account.");
    }
}