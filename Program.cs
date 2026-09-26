Account savingsAccount = new SavingsAccount();

savingsAccount.Owner = "Shady";
savingsAccount.Deposit(1000);
savingsAccount.Withdraw(200);

savingsAccount.ShowBalance();
savingsAccount.ShowAccountType();


Account currentAccount = new CurrentAccount();

currentAccount.Owner = "Shady";
currentAccount.Deposit(500);

currentAccount.ShowBalance();
currentAccount.ShowAccountType();