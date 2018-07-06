using System;

namespace PairProgramming
{
    public class BankAccount
    {
        public string User { get; set; }

        public string AccountName { get; set; }

        public DateTime DateOpened { get; set; }

        public double Funds { get; set; }

        public BankAccount(string user, string accountName, DateTime dateOpened, double funds)
        {
            this.User = user;
            this.AccountName = accountName;
            this.DateOpened = dateOpened;
            this.Funds = funds;
        }

        public void ApplyTransaction(double amount)
        {
            System.Console.WriteLine("Transaction applied, {0} added", amount);
            this.Funds += amount;
        }


    }
}


// A Bank account class
// Required data
// Come up with 4 attributes needed by all accounts
// Required method
// Apply transaction
// Clarifications:
// This is not a main account
// The two accounts below are not the only account types possible
// Consider mortgage, investment and loan accounts as well.
