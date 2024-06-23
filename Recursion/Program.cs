using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {
        static int factorial(int f)             //Факториал вводимого числа
        {
            Console.WriteLine("Action: factorial function triggered;");
            if (f == 0) { return 1; }
            else return f * factorial(f - 1);
        }
        static int power(int r, int p)           //Степень указанного числа
        {
            Console.WriteLine("Action: power function triggered;");
            if (r == 0) { return 0; }
            else if (p == 0 || r == 1) { return 1; }
            else if (p == 1) { return r; }
            else return r * power(r, p - 1);
        }
        static int fibonacchi_lim(int x1, int x2, int x3, int lim)      //Ряд чисел фибоначчи для указанного лимита
        {
            //Console.WriteLine("Action: fibonacchi function triggered;");
            x3 = x1 + x2;
            x1 = x2; x2 = x3;
            Console.Write($"{x3}, ");
            if (x3 < lim) { return fibonacchi_lim(x1, x2, x3, lim); }
            else return 0;
        }
        static int fibonacchi_num(int x1, int x2, int x3, int num)      //Ряд чисел фибоначчи до указанного кол-ва эл-тов
        {
            x3 = x1 + x2;
            x1 = x2; x2 = x3;
            int i = 0; i++;
            Console.Write($"{x3}, ");
            if (i < num) { return fibonacchi_lim(x1, x2, x3, num); }
            else return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, для которого нужно расчитать факториал: ");
            int fact, res_fact = 0;
            fact = Convert.ToInt32(Console.ReadLine());
            res_fact = factorial(fact);
            Console.WriteLine($"Факториал числа {fact} = {res_fact}");
            Console.WriteLine("Введите число, которое нужно возвести в степень: ");

            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень, в которую нужно возвести число: ");
            b = Convert.ToInt32(Console.ReadLine());
            c = power(a, b);
            Console.WriteLine(c);

            Console.WriteLine("введите лимит для чисел фибоначчи: ");
            int lim = Convert.ToInt32(Console.ReadLine());
            int x1 = 0, x2 = 1, x3 = 0;
            Console.Write("0, 1, ");
            int x = fibonacchi_lim(x1, x2, x3, lim);
            Console.WriteLine();

            Console.WriteLine("Введите количество чисел для ряда Фибоначчи: ");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            int y = fibonacchi_num(x1, x2, x3, lim);

        }
    }
}
