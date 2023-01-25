using CSharpUdemy;

Console.Write("Enter de account number: ");
int accountNumber = int.Parse(Console.ReadLine());

Console.Write("Enter the name of the account's ownner: ");
string accountOwnerName = Console.ReadLine();

Console.Write("There will be an initial deposit? (Y/N) ");
char initialDeposit = char.Parse(Console.ReadLine());
double initialDepositValue = BankAccount.InitialDeposit(initialDeposit);

Console.WriteLine("");
BankAccount firstAccount = new BankAccount(accountNumber, accountOwnerName, initialDepositValue);
firstAccount.AccountInformation();

Console.WriteLine("");
Console.Write("Enter a deposit value: ");
double depositValue = double.Parse(Console.ReadLine());
firstAccount.Deposit(depositValue);
Console.WriteLine("");
firstAccount.AccountInformation();
Console.WriteLine("");
Console.Write("Enter a withdraw value: ");
double withdrawValue = double.Parse(Console.ReadLine());
firstAccount.Withdraw(withdrawValue);
firstAccount.AccountInformation();

