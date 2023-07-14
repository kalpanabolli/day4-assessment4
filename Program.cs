using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number");
            num = int.Parse(Console.ReadLine());
            if (num != 0)
            {
                var result = num % 2 == 0 ? "The Number is Even" : "The Number is Odd";

                if (num != 0)
                {

                    var result1 = num > 0 ? "The Number is Positive" : "The Number is Negative";
                    Console.WriteLine(result1);
                }
                Console.WriteLine(result);
            }
            else if (num == 0)
            {
                Console.WriteLine("number is Zero");
            }
            Console.ReadKey();
        }
    }
}
