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

    // This method can be changed by subclasses.
    public virtual void ShowAccountType()
    {
        Console.WriteLine("This is a bank account.");
    }
}

// SavingsAccount inherits from BankAccount.
public class SavingsAccount : BankAccount
{
    // Override changes the behavior of the inherited method.
    public override void ShowAccountType()
    {
        Console.WriteLine("This is a savings account.");
    }
}

// CurrentAccount also inherits from BankAccount.
public class CurrentAccount : BankAccount
{
    // Override gives this class its own behavior.
    public override void ShowAccountType()
    {
        Console.WriteLine("This is a current account.");
    }
}