BankAccount account = new BankAccount();

account.Owner = "Shady";
account.Deposit(1000);
account.Withdraw(200);

account.ShowBalance();
account.ShowAccountType();

SavingsAccount savingsAccount = new SavingsAccount();

savingsAccount.Owner = "Shady";
savingsAccount.Deposit(500);

savingsAccount.ShowBalance();
savingsAccount.ShowAccountType();

CurrentAccount currentAccount = new CurrentAccount();

currentAccount.Owner = "Shady";
currentAccount.Deposit(300);

currentAccount.ShowBalance();
currentAccount.ShowAccountType();