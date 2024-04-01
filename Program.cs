using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write( "Введите значения параметра x = ");
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);

            double F = Math.Cos(x) + Math.Cos(x);

            Console.Write($"Для значен x = {x}, F = {F} ");
            Console.Write("Осинкна ВВ 31ИС");
        }
    }
}
