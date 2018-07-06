using System;

namespace PairProgramming
{
    public class Transaction : BankAccount
    {
        public Transaction(string user, string accountName, DateTime dateOpened, double funds) : base(user, accountName, dateOpened, funds)
        {
        }

        public double Deposit{ get; set; }
        public double Withdrawel{ get; set; }

        public double DepositTransaction(double deposit)
        {
            System.Console.WriteLine("Deposit is accepted");
            return Funds + Deposit;
        }

        public double WithdrawelTransaction(double withdrawel)
        {
            System.Console.WriteLine("Withdrawel is accepted");
            return Funds - Withdrawel;
        }
        
    }
}

// Minimum data:
// Amount
// Come up with at least 2 other attributes
// Transactions only come as two base types (you must deduce the types). Accounts can have more complicated transactions however when in a bank account a transaction only affects one item deduce that item.
