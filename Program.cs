BankAccount account = new BankAccount();

account.Owner = "Shady";

account.Deposit(1000);
account.Withdraw(200);

account.ShowBalance();

SavingsAccount savingsAccount = new SavingsAccount();

savingsAccount.Owner = "Shady";
savingsAccount.Deposit(500);

savingsAccount.ShowBalance();
savingsAccount.ShowSavingsAccount();