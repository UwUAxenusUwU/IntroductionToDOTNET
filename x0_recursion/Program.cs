using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x0_recursion
{
    internal class Program
    {
        static void start(char[,] arr)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = '*';
                    Console.Write(arr[i, j] + ' ');
                }
                Console.WriteLine();
            }
        }
        static void draw(char[,] arr)
        {
            for (int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < 3; j++)
                { 
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static void bot_set(char[,] arr, bool turn_x)
        {
            bool unique = false;
            while (unique == false)
            {
                Random rnd = new Random();
                int i = rnd.Next(0,3);
                int j = rnd.Next(0,3);
                if (arr[i, j] == '*')
                {
                    arr[i,j] = turn_x ? 'x' : 'o';
                    unique = true;
                    Console.WriteLine($" i = {i}, j = {j} {turn_x}");
                }
            }
            turn_x = !turn_x;
        }
        static char game(char[,] arr, bool turn_x)
        {
            bool end = false;
            Console.Clear();
            bot_set(arr, turn_x);
            draw(arr);
            for (int i = 0;i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    if (arr[i, j] == '*')
                    {
                        end = false;
                    }
                    else end = true;
            }
            while (!end) return game(arr, turn_x);
            return ' ';
        }
        //static bool logic(char[,] arr, bool gameover)
        //{
        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {

        //        }
        //        Console.WriteLine();
        //    }
        //    return true;
        //}
        static void Main(string[] args)
        {
            char[,] arr = new char [3,3];
            bool turn_x = true;
            start(arr);
            game(arr, turn_x);

        }
    }
}
