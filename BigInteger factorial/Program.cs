using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BigInteger_factorial
{
    internal class Program
    {
        static BigInteger factorial(BigInteger f)             //Факториал вводимого числа
        {
            if (f == 0) { return 1; }
            else return f * factorial(f - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, для которого нужно расчитать факториал: ");
            BigInteger fact, res_fact = 0;
            fact = Convert.ToInt32(Console.ReadLine());
            res_fact = factorial(fact);
            Console.WriteLine($"Факториал числа {fact} = {res_fact}");
        }
    }
}
