using System;
namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new bankAccount("taghi",100);
            Console.WriteLine($"accont {account.Number} was created for {account.Owner} with {account.Balance}");

            account.MakeWithdrawal(10, DateTime.Now, "hi");
            Console.WriteLine(account.Balance);
            try
            {
                var invalidAccount = new bankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            { 
                // Console.WriteLine("exception caught creating account with negative balance");
                // Console.WriteLine(e.ToString());
            }
            

            Console.WriteLine("\n \n \n");
            account.MakeWithdrawal(20,DateTime.Now,"for xbox");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.getAccountHistory());

        }
    }
}