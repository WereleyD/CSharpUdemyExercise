using CSharpUdemy;

BankAccount firstAccount = new BankAccount();

Console.Write("Enter de account number: ");
int accountNumber = int.Parse(Console.ReadLine());
firstAccount.setAccountNumber(accountNumber);
Console.Write("Enter the name of the account's ownner: ");
string accountOwnerName = Console.ReadLine();
firstAccount.setAccountName(accountOwnerName);
Console.WriteLine("There will be an initial deposit? Y/N");
char initialDeposit = char.Parse(Console.ReadLine());
firstAccount.InitialDeposit(initialDeposit);
Console.WriteLine("");
firstAccount.AccountInformation();
Console.WriteLine("");
Console.Write("Enter a deposit value: ");
double depositValue = double.Parse(Console.ReadLine());
firstAccount.Deposit(depositValue);
firstAccount.AccountInformation();
Console.WriteLine("");
Console.Write("Enter a withdraw value: ");
double withdrawValue = double.Parse(Console.ReadLine());
firstAccount.Withdraw(withdrawValue);
firstAccount.AccountInformation();

