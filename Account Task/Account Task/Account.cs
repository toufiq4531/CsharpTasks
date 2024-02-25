using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Task
{
    class Account
    {
        private string accName;
        private string acid;
        private double balance;

        public Account()
        {
            accName = "Tofiqul";
            acid = "49450";
            balance = 200000;
        }
        public Account(string a, string b, double c)
        {
            this.accName = a;
            this.acid = b;
            this.balance = c;
        }

        public void setAccName(string m)
        {
            accName = m;
        }

        public void setAccId(string n)
        {
            acid = n;
        }

        public void setBalance(double o)
        {
            balance = o;
        }

        public string getAccName()
        {
            return accName;
        }

        public string getAccId()
        {
            return acid;
        }

        public double getBalance()
        {
            return balance;
        }

        public void deposit(double amount)
        {
            balance += amount;
        }
        public void withdraw(double amount)
        {
            balance -= amount;
        }
        public void transfer(double amount, Account receiver)
        {
            balance = this.balance - amount;
            receiver.deposit(amount);
        }

        public void printInfo()
        {
            Console.WriteLine("Account Name: "+ accName);
            Console.WriteLine("Account ID: "+ acid);
            Console.WriteLine("Account Balance: "+ balance);
        }
    }
}
