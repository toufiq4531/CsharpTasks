using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodModifier
{
    class Class2
    {
        int num;

        public int Num 
        {
            get { return num; } 
            set 
            {
                num = value;
            }
                 
        }

        public static void SimpleMethod(params object[] arr)
        {                        

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write((arr[i]));
                Console.Write(", ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int a = 20, b = 1988;

            
            SimpleMethod(a, b);
            SimpleMethod(10, 20, 30);
            SimpleMethod("XYZ", true);

            Console.ReadKey();
        }
    }
}
