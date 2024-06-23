//#define INTEGRAL_TYPES
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static readonly string delimiter = "\n--------------------------------------------------------\n";
        static void Main(string[] args)
        {
#if INTEGRAL_TYPES
            Console.WriteLine("int");
            Console.WriteLine($"Занимает {sizeof(short)} байта");
            Console.WriteLine($"Диапозон принимаемых значений: {short.MinValue} .... {short.MaxValue}");
            Console.WriteLine(delimiter);
            Console.WriteLine("int");
            Console.WriteLine($"Занимает {sizeof(ushort)} байта");
            Console.WriteLine($"Диапозон принимаемых значений: {ushort.MinValue} .... {ushort.MaxValue}");
            Console.WriteLine(delimiter);
            Console.WriteLine("int");
            Console.WriteLine($"Занимает {sizeof(uint)} байта");
            Console.WriteLine($"Диапозон принимаемых значений: {uint.MinValue} .... {uint.MaxValue}");
            Console.WriteLine(delimiter); 
#endif
            int a = 2;
            uint b = 3;
            //a = b;
            a = (int)b;
            Console.WriteLine(a + b);
        }
    }
}
