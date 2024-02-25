using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDemo
{
    class TestBank
    {     //Compile time constant, global constant . implicit static varible
        //class constant
        const int TransactionLimit = 500000;

        //Run time constant, object wise constant
        readonly int CreditLimit;

        public TestBank(int value)
        {
            this.CreditLimit = value;
        }
        
        static void Main(string[] args)
        {
            TestBank b1 = new TestBank(10000);
            TestBank b2 = new TestBank(20000);
            TestBank b3 = new TestBank(30000);

            
            

        }
    }
}
