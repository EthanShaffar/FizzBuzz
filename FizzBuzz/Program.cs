using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        /// <summary>
        /// This will simply call the function FizzBuzz with the parameters that will be placed
        /// (ex: between 1-50)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (var i = 0; i <= 20; i++)
            {
                FizzBuzz(i);
                
            }
            Console.ReadKey();
        }
        /// <summary>
        /// This is FizzBuzz!
        /// IIt will take the number and confirm if 1st divisable by both 5 & 3.
        /// then just 5.
        /// then just 3.
        /// and print a result based on that.
        /// </summary>
        /// <param name="num"></param>
        static void FizzBuzz(int num)
        {
            if (num % 5 == 0 && num % 3 == 0)
            {
                Console.WriteLine("FIZZBUZZ!!!");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Fizz!");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Buzz!");
            }
            else
            {
                Console.WriteLine(num);
            }
        }
    }
}
