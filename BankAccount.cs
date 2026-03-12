using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    internal class BankAccount
    {
        static void Main(string[] args)
        {
            BankAccountDetails ac1 = new BankAccountDetails("Tae Hyung", 50000);
            BankAccountDetails ac2 = new BankAccountDetails("Jungkook", 100000);

            ac1.Deposit(10000);
            ac2.Withdraw(5000);

            ac2.Deposit(1000);
            ac1.Withdraw(500);

            ac1.Deposit(2000);
            ac2.Withdraw(3500);

            Console.WriteLine("FinalBalance : ");
            Console.WriteLine(ac1.AccountHolder + " : " + ac1.Balance);
            Console.WriteLine(ac2.AccountHolder + " : " + ac2.Balance);

            if(ac1.Balance > ac2.Balance)
            {
                Console.WriteLine("Winner is : " + ac1.AccountHolder);
            }
            else
            {
                Console.WriteLine("Winner is : " + ac2.AccountHolder);
            }

            



        }
    }
}
