using System;

namespace PairProgramming
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string user, string accountName, DateTime dateOpened, double funds)
            :base(user, accountName, dateOpened, funds)
        {

        }
        public double ServiceFee { get; set; }

        public double ServiceFeeTransaction(double serviceFee)
        {
            System.Console.WriteLine("Service fee submitted to queue");
            return serviceFee;
        }
    }
}

// A Checking account class
// Required Data
// Service Fee
// Required method
// Create transaction for yearly service fee and submit the transaction to the queue
