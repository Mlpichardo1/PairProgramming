using System;
using System.Collections;

namespace PairProgramming
{
    public class QueueTransaction : BankAccount
    {
        public QueueTransaction(string user, string accountName, DateTime dateOpened, double funds) : base(user, accountName, dateOpened, funds)
        {
        
        }
        // Creates and initializes a new Queue.
        Queue myQ = new Queue();
        
    }
}