public abstract class Account
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

    // Every account type must define its own account type.
    public abstract void ShowAccountType();
}

// SavingsAccount inherits from the abstract Account class.
public class SavingsAccount : Account
{
    public override void ShowAccountType()
    {
        Console.WriteLine("This is a savings account.");
    }
}

// CurrentAccount also inherits from the abstract Account class.
public class CurrentAccount : Account
{
    public override void ShowAccountType()
    {
        Console.WriteLine("This is a current account.");
    }
}