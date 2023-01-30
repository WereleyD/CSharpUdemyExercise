using CSharpUdemy;

int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

int[,] mat = new int[n, m];

for (int i = 0; i < n; i++)
{
    string[] str = Console.ReadLine().Split(' ');
    for (int j = 0; j < m; j++)
    {
        mat[i,j] = int.Parse(str[j]);
    }
}

MultidimensionalArray.FindNumbers(n, m, mat);



//MultidimensionalArray

Console.Write("Size: ");
int x = int.Parse(Console.ReadLine());

int[,] matriz = new int[x, x];

for (int i = 0; i < x; i++)
{
    string[] values = Console.ReadLine().Split(' '); //guarda no vetor os valores que foram separados por espaço.
    for (int j = 0; j < x; j++)
    {
        matriz[i, j] = int.Parse(values[j]);
    }
}

for (int i = 0; i < x; i++)
{
    for (int j = 0; j < x; j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}

MultidimensionalArray.MainDiagonal(x, matriz);
MultidimensionalArray.NegativeNumbers(x, matriz);
Console.ReadLine();


//RoomsRented

Console.Write("How many rooms will be rented? ");
int op = int.Parse(Console.ReadLine());
RoomsRented[] vect = new RoomsRented[10];

for (int i = 0; i < op; i++)
{
    Console.WriteLine($"Rent #{i + 1}");
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("E-mail: ");
    string email = Console.ReadLine();
    Console.Write("Room: ");
    int roomNum = int.Parse(Console.ReadLine());
    vect[roomNum] = new RoomsRented(name, email);
}
for (int i = 0; i < 10; i++)
{
    if (vect[i] != null)
    {
        Console.WriteLine($"Room {i}");
        Console.WriteLine(vect[i]);
        Console.WriteLine();
    }
}
Console.ReadLine();

//BankAccount

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

