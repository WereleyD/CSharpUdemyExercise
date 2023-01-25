using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUdemy
{
    public class BankAccount
    {
        public string AccountName { get; private set; }
        public int AccountNumber { get; private set; } = 0;
        public double AccountBalance { get; private set; }
        public double WithdrawFee { get; private set; } = 5;

        public void setAccountName(string name)
        {
            AccountName = name;
        }
        public void setAccountNumber(int accountNumber) { 
            if(AccountNumber == 0)
            {
                AccountNumber = accountNumber;
            }
            else
            {
                Console.WriteLine("It's not possible to change the account number.");
            }
        }

        public void Withdraw(double withdrawValue)
        {
            if(withdrawValue > 0)
            {
                AccountBalance -= withdrawValue + WithdrawFee;
            }
        }
        public void Deposit(double depositValue)
        {
            if (depositValue > 0)
            {
                AccountBalance += depositValue;
            }
            else { Console.WriteLine("Invalid value. Try again."); }
        }
        public void InitialDeposit(char op)
        {
            if (op == 'y')
            {
                Console.Write("What's the value of your initial deposit? ");
                double depositValue = double.Parse(Console.ReadLine());
                Deposit(depositValue);
            }
            else if (op == 'n')
            {
                Deposit(0);
            }
            else
            {
                Console.WriteLine("Invalid option. Try again.");
            }
        }
        public void AccountInformation()
        {
            Console.WriteLine("Account Information:\n" +
                $"Account Number: {AccountNumber}, Account Owner: {AccountName}, Balance: $ {AccountBalance}");
        }
    }
}
