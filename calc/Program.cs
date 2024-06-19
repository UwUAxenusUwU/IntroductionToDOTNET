using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    internal class Program
    {
        static void calc()
        {
            Console.WriteLine("Введите числа: ");
            double a = 0.0, b = 0.0, c = 0.0;
            char act;
            do
            {
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Выберите операцию (+, -, *, /):");
                act = Convert.ToChar(Console.ReadLine());
                switch (act)
                {
                    case '+':
                        c = a + b;
                        Console.WriteLine($"{a} {act} {b} = {c}");

                        break;
                    case '-':
                        c = a - b;
                        Console.WriteLine($"{a} {act} {b} = {c}");
                        act = ' ';
                        break;
                    case '*':
                        c = a * b;
                        Console.WriteLine($"{a} {act} {b} = {c}");
                        act = ' ';
                        break;
                    case '/':
                        c = a / b;
                        Console.WriteLine($"{a} {act} {b} = {c}");
                        act = ' ';
                        break;
                    default:
                        Console.WriteLine("Такой операции нет");
                        break;
                }
            } while (act != Convert.ToChar('e'));                          //выход

        }
        static void Main(string[] args)
        {
             calc();
        }
    }
}
