public class BankAccount
{
    public string Owner { get; set; }
    public double Balance { get; set; }

    public void ShowBalance()
    {
        Console.WriteLine($"Balance: {Balance}");
    }
}