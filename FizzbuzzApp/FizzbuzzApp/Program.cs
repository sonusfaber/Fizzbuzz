using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzbuzzApp
{
    class Program
    {
        public const int _firstNumber = 3;
        public const int _secondNumber = 5;


        static void Main(string[] args)
        {

            for(int i = 1; i <= 100; i++)
            {
                if ((i % _firstNumber) == 0 && (i % _secondNumber) == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if((i % _firstNumber) == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if((i % _secondNumber) == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i.ToString());
                }

            }

        }
    }
}
