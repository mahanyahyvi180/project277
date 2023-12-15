using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp139
{
    class Program
    {
        static void Main(string[] args)
        {
            var continueloop = true;

            do
            {

                try
                {

                    Console.WriteLine($"Enter an integer numerator:");
                    var numerator = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Enter an integer denominator:");
                    var denominator = int.Parse(Console.ReadLine());

                    var result = numerator / denominator;

                    Console.WriteLine($"\nResult:{numerator}/{denominator}={result}");
                    continueloop = false;
                    Console.ReadLine();
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine($"{formatException.Message}\n");
                    Console.WriteLine("errorrrrrrrrrrrrrrrrrrrrrr.\n");
                }
                catch (DivideByZeroException divideByZeroException)
                {
                    Console.WriteLine($"{divideByZeroException.Message}");
                    Console.WriteLine($"errorrrrrrrrrrrrrrrrrrrrr.\n");
                }
            } while (continueloop);
            Console.ReadLine();




        }
    }
}
