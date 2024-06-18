using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace dz16._06
{
    internal class Program
    {
        static void rectangle()                 //функция прямоугольника без фильтрации ввода
        {
            Console.WriteLine("Введите размер прямоугольника (x и y)");
            uint x = Convert.ToUInt32(Console.ReadLine());
            uint y = Convert.ToUInt32(Console.ReadLine());
            for (int j = 0; j < y; j++)
            {
                for (int i = 0; i < x; i++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
        static void triangle()
        {
            Console.WriteLine("Выберите версию треугольника (от 1 до 4): ");
            uint ver = Convert.ToUInt32(Console.ReadLine());
            uint x = 0;
            uint y = 0;
            switch (ver)
            {
                case 1:
                    Console.WriteLine("Введите высоту: ");
                    y = Convert.ToUInt32(Console.ReadLine());
                    for (int j = 0; j < y; j++)
                    {
                        for (int i = 0; i < j; i++)
                        {
                            Console.Write('*');
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    Console.WriteLine("Введите ширину: ");
                    x = Convert.ToUInt32(Console.ReadLine());
                    for (int j = 0; j < x; j++)
                    {
                        for (int i = j; i < x; i++)
                        {
                            Console.Write('*');
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    Console.WriteLine("Введите ширину: ");
                    x = Convert.ToUInt32(Console.ReadLine());
                    for (int j = 0; j < x; j++)
                    {
                        for (int n = 0; n < j; n++)
                        {
                            Console.Write(' ');
                        }
                        for (int i = j; i < x; i++)
                        {

                            Console.Write('*');
                        }
                        Console.WriteLine();
                    }
                    break;
                case 4:
                    Console.WriteLine("Введите высоту: ");
                    y = Convert.ToUInt32(Console.ReadLine());
                    for (int j = 0; j < y+1; j++)
                    {
                        for (int n = j; n < y; n++)
                        {
                            Console.Write(' ');

                        }
                        for (uint i = 0; i < j; i++)
                        {
                            Console.Write('*'); 
                        }
                        Console.WriteLine();
                    }
                    break;
            }
        }
        static void rhomb()
        {
            Console.WriteLine("Введите высоту ромба: ");
            uint y = Convert.ToUInt32(Console.ReadLine());
            for (int i = 0; i < y; i++)
            {
                for(int j = i;j < y; j++)
                {
                    Console.Write(' ');
                }
                Console.Write('/');
                for (uint j = 0; j < 2 * i; j++)
                {
                    Console.Write(' ');
                }
                Console.Write('\\');
                Console.WriteLine();
            }
            for (int i = 0; i < y; i++)
            {
                for (int j = 0;j < i + 1; j++)
                { 
                    Console.Write(" "); 
                }
                Console.Write('\\');
                for (int j = 2 * i; j < 2 * y - 2; j++)
                {
                    Console.Write(' ');
                }
                Console.Write('/');
                Console.WriteLine();
            }
 
        }
        static void chered_ractangle()
        {
            Console.WriteLine("Введите размер прямоугольника (x и y)");
            uint x = Convert.ToUInt32(Console.ReadLine());
            uint y = Convert.ToUInt32(Console.ReadLine());
            for (int j = 0; j < y; j++)
            {
                for (int i = 0; i < x; i++)
                {
                    if ((j + i)% 2 == 0)
                    { 
                    Console.Write('+');
                    }
                    else 
                    {
                        Console.Write('-');
                    }
                }
                Console.WriteLine();
            }
        }
        static void ascii_table()
        {
            for (int i = 0; i < 256; i++)
            {
                Console.Write(Convert.ToChar(i) + " - " + i + "; ");
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
        static void chess_board()
        {
            Console.WriteLine("Введите размер доски: ");
            uint size = Convert.ToUInt32(Console.ReadLine());
            for (int i = 0; i <= size ; i++)
            {
                for (int j = 0; j <= size; j++)
                {
                    if (i == 0 && j == 0) { Console.Write('╔'); }
                    else if (i == 0 && j == size) { Console.Write('╗'); }
                    else if (i == size && j == 0) { Console.Write('╚'); }
                    else if (i == size && j == size) { Console.Write('╝'); }
                    else if (i == 0 || i == size) { Console.Write('═'); }
                    else if (j == 0 || j == size) { Console.Write('║'); }
                    else if ((i + j) % 2 == 0) { Console.Write('#'); }
                    else { Console.Write(' '); };
                    
                }

                Console.WriteLine();
            }
        }
        static void hard_chess()
        {
            Console.WriteLine("Введите размер доски: ");
            uint size = Convert.ToUInt32(Console.ReadLine());
            for (int i = 0; i < size ; i++)                //глобал строки
            {
                for (int j = 0;j < size; j++)              //глобал стобцы
                {
                    for (int k = 0; k < size; k++)  //отрисовка каждой строки
                    {
                        for (int l = 0; l < size; l++)     //отрисовка клеток построчно
                        {
                            if (i % 2 == 0)
                            {
                                Console.Write("* ");
                            }
                            //else Console.Write(' ');
                        }
                        for (int m = 0; m < size; m++)     //same as prev
                        {
                            if (i % 2 == 0)
                            {
                                Console.Write("  ");
                            }
                        //else Console.Write('*');
                        }
                    }
                        Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("https://github.com/okovtun/BV_011/blob/master/ControlStructures/Geometria/Task/Geometria1.txt");
            rectangle();
            triangle();
            triangle();
            triangle();
            triangle();
            rhomb();
            chered_ractangle();
            //ascii_table();
            Console.WriteLine("https://github.com/okovtun/BV_011/blob/master/ControlStructures/Geometria/Task/ChessBoard.jpg");
            chess_board();
            hard_chess();
            


        }
    }
}
