using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void move()
        {
            ConsoleKeyInfo key;                 //хотел сделать по красоте, нашёл такое решение считывания упарвления
                int x = 0, y = 0;                                           //позиция
            do
            {


                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        System.Console.Clear();
                        y--;
                        Console.SetCursorPosition(x, y);
                        Console.Write('■');
                        break;
                    case ConsoleKey.DownArrow:
                        System.Console.Clear();
                        y++;
                        Console.SetCursorPosition(x, y);
                        Console.Write('■');
                        break;
                    case ConsoleKey.LeftArrow:
                        System.Console.Clear();
                        x--;
                        Console.SetCursorPosition(x, y);
                        Console.Write('■');
                        break;
                    case ConsoleKey.RightArrow:
                        System.Console.Clear();
                        x++;
                        Console.SetCursorPosition(x, y);
                        Console.Write('■');
                        break;
                    default:
                        Console.Beep();                     //пищит если нажать не ту клавишу
                        break;
                }
            }
            while (key.Key != ConsoleKey.Escape);
            System.Console.Clear();
            Console.WriteLine("Game over");

        }
        static void Main(string[] args)
        {
            Console.Write('■');
            move();
        }
    }
}
