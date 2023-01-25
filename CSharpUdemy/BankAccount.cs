using CSharpUdemy.ErrorExceptions;
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

        public BankAccount(int accountNumber, string name, double initialDeposit)
        {
            AccountName = name;
            AccountNumber = accountNumber;
            AccountBalance = initialDeposit;
        }

        public void setAccountName(string name)
        {
            AccountName = name;
        }
        public void setAccountNumber(int accountNumber)
        {
            if (AccountNumber == 0)
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
            if (withdrawValue > 0)
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
        public static double InitialDeposit(char op)
        {
            if (op == 'y')
            {
                Console.Write("What's the value of your initial deposit? ");
                double depositValue = double.Parse(Console.ReadLine());
                return depositValue;
            }
            else if (op == 'n')
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Error.");
                throw new InvalidValueException("Invalid Value. Please use \"y\" or \"n\"").Message();
            }
        }
        public void AccountInformation()
        {
            Console.WriteLine("Account Information:\n" +
                $"Account Number: {AccountNumber}, Account Owner: {AccountName}, Balance: $ {AccountBalance}");
        }
    }
}
