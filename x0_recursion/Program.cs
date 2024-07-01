using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace x0_recursion
{
    internal class Program
    {
        static int turn = 0;
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
        static void bot_set(char[,] arr)
        {
            bool unique = false;

            while (unique == false)
            {
                Random rnd = new Random();
                int i = rnd.Next(0,3);
                int j = rnd.Next(0,3);
                if (arr[i, j] == '*')
                {
                    if (turn % 2 == 0) { arr[i, j] = 'x'; turn++; }
                    else
                    {
                        arr[i, j] = 'o'; turn++;
                    }
                    //arr[i,j] = turn_x ? 'x' : 'o';
                    unique = true;
                    //turn_x = !turn_x;
                    //Console.WriteLine($" i = {i}, j = {j} {turn}");
                }
            }
        }
        static char game(char[,] arr)
        {
            bool end = false;
            Console.Clear();
            bot_set(arr);
            draw(arr);
            for (int i = 0;i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    if (arr[i, j] == '*')
                    {
                        end = false; break;
                    }
                    else end = true;
            }
            Thread.Sleep(500);
            while (!end) return game(arr);
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
            start(arr);
            game(arr);

        }
    }
}
