using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account();
            a1.printInfo();

            Console.WriteLine();
            
            Account a2 = new Account();
            a2.setAccName("Pranto");
            a2.setAccId("42310");
            a2.setBalance(500000);
            a2.printInfo();

            Console.WriteLine();
            /*
            a2.deposit(2345);
            a2.printInfo();

            Console.WriteLine();

            a2.withdraw(1000);
            a2.printInfo();
            
            Console.WriteLine();
            */

            a2.transfer(10000, a1);
            Console.WriteLine(a1.getAccId()+ " Account Balance After Receiving: "+ a1.getBalance());
            Console.WriteLine(a2.getAccId()+ " Account Balance After Transfering: "+ a2.getBalance());
            
            
            Console.ReadKey();
        }
    }
}
