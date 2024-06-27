using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите номер этажа: ");
            //int floor = Convert.ToInt32(Console.ReadLine());
            //Elevator(floor);

            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{n} factorial = {factorial(n)}");
        }
        static void Elevator(int floor)
        {
            if (floor == 0)
            {
                Console.WriteLine("You`re in the basement!");
                return;
            }
            Console.WriteLine($"You are on the {floor} floor;");
            Elevator(floor-1);
            Console.WriteLine($"You are on the {floor} floor;");
        }
        static int factorial(int n)
        {

        }
    }

}
