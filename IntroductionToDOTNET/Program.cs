//#define CONSOLE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
    internal class Program
    {
        static void Main(string[] args)
        {

#if CONSOLE
            Console.Title = "Введение в .NET";
            Console.WriteLine("Hello .NET");
            Console.WriteLine("Привет .NET");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.CursorLeft = 32;
            Console.CursorTop = 11;
            Console.Beep(37, 2000);
            Console.Clear();
            Console.WriteLine("Привет .NET");
            Console.ResetColor(); 
#endif

            Console.WriteLine("Введите ваше имя");
            string FirstName = Console.ReadLine();
            Console.WriteLine(FirstName);
            Console.WriteLine("Введите вашу фамилию");
            string LastName = Console.ReadLine();
            Console.WriteLine(LastName);
            Console.WriteLine("Введите ваш возраст");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age);

        }
    }
}
