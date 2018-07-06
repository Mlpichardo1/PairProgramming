using System;

namespace PairProgramming
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string user, string accountName, DateTime dateOpened, double funds)
            :base(user, accountName, dateOpened, funds)
        {

        }
        public double InterestRate { get; set; }

        public double InterestTransaction(double interestRate)
        {
            System.Console.WriteLine("Interest submitted to queue");
            return interestRate;
        }

    }
}


// A Savings account class
// Required data
// Interest rate
// Required method
// Create transaction for interest and submit the transaction to the queue.
