using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDowhileLoops
{
    internal class WhileDowhile
    {
        static void Main(string[] args)
        {
            //while loops
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
            Console.ReadKey();

            //DoWhile loops
            int number1 = 200;
            do
            {
                Console.WriteLine(number1);
                number1--;
            } while (number1 >= 100);
            Console.WriteLine("Now number is {0}", number1);
            Console.ReadKey();
        }

    }
}

