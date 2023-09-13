using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Working_With_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Int is "+50);
            Console.WriteLine("Addition is "+ (6 + 4));
            Console.WriteLine("Subtraction is "+ (6 - 5));
            Console.WriteLine("Division is " + 5/2.0);
            Console.WriteLine("Remainder is "+ 6 % 4);
            
            int num1 = 2;
            num1 = num1 + 1;
            num1 += 3;
            Console.WriteLine("Num1= "+ num1);
            int num2 = 2;
            num2++;
            Console.WriteLine("Num 2 = "+ num2);
            Console.WriteLine(Math.Abs(-5));
            Console.WriteLine(Math.Min(5, 35));
            Console.WriteLine(Math.Pow(2, 4));



            //freeze the console
            Console.ReadLine();

        }
    }
}
