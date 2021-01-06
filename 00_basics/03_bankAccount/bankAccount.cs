using System;
using System.Collections.Generic;
using System.Text;  
namespace myBank
{
    public class bankAccount
    {
        public string Number{get;}
        public string Owner {get; set;}
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance = balance + item.Amount;
                }
                return balance;
            }
        }
        private static int accontNumberSeed = 1324567890;
        private List<Transaction> allTransactions = new List<Transaction>();
        public bankAccount(string name, decimal initialBalance) 
        {
            this.Owner = name;
            this.Number =accontNumberSeed.ToString();
            makeDeposit(initialBalance, DateTime.Now, "Initial Balance");
            accontNumberSeed ++;
        }
        public void makeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount<0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of depositemust be positive!");
            }
            var deposit = new Transaction (amount, date, note);
            allTransactions.Add(deposit);
        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount<0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "amount of withdrawal must be positive!");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal!");
            }
            var withdrawal = new Transaction(-amount,date, note);
            allTransactions.Add(withdrawal);
        }

        public string getAccountHistory()
        {
            var report = new StringBuilder();
            //header
            report.AppendLine("date \t Amount\t Note");
            foreach (var item in allTransactions)
            {
                //rows
                report.AppendLine($"{item.Date}\t{item.Amount}\t{item.Notes}");
            }
            return report.ToString();
        }
    }
}